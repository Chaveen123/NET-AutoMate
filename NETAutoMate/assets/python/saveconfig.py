from napalm import get_network_driver
from netmiko import ConnectHandler
import csv
import sys

def commit():
    net_connect = ConnectHandler(device_type=netmiko,ip=ip,username=username,password=password)
    
    net_connect.enable()
  
    if(netmiko=="juniper"):
        net_connect.commit()
    else:
        net_connect.send_command('write')

    net_connect.disconnect()

    print ('Configuration Commit SUCCESSFUL!')

def saveconfig():
    device.open()

    if len(sys.argv)>1:

        option= sys.argv[1]
    
        if(option == "commit"):
            commit()
                
        elif(option =="rollback"):
            device.rollback()
            print ('Configuration Rollback SUCCESSFUL!')

    else:
        device.load_replace_candidate(config=device.get_config()['startup'])
        if len(device.compare_config()) == 0:
            print("No Configuration Changes!")
        else:
            print(device.compare_config())

    device.close()

try:
    with open('C:\\NETAutoMate\\DeviceAuth.csv','r') as deviceauth:
        csvreader = csv.reader(deviceauth)
        for row in csvreader:
            device_vendor=row[0]
            device_model=row[1]
            device_type=row[2]           
            netmiko=row[3]
            ip=row[4] 
            username=row[5]
            password=row[6]

    if(device_vendor=='Arista'):    
        driver = get_network_driver('eos')
        device = driver(hostname=ip, username=username, password=password, optional_args={'transport':'http'})
        saveconfig()

    elif(device_vendor=='Cisco'):
        try:
            driver = get_network_driver('ios')
            device = driver(hostname=ip, username=username, password=password)
            saveconfig()
        except:
            driver = get_network_driver('nxos_ssh')
            device = driver(hostname=ip, username=username, password=password)
            saveconfig()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        saveconfig()
   
except Exception as e:
    
    print(f'System was UNABLE to Save Configuration. Please Retry!\nError: {e}')
