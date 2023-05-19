import csv
from napalm import get_network_driver
import sys

vlanid = sys.argv[1]

def getvlanaccessports():
    device.open()

    accessports = device.get_vlans()
    
    try:
        for x in accessports[vlanid]['interfaces']:
                        if 'Cpu' in x:
                            pass                 
                        else:                      
                            print(x)
    except:
        for x in accessports[int(vlanid)]['interfaces']:
                        if 'Cpu' in x:
                            pass                 
                        else:                      
                            print(x)
    
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
        getvlanaccessports()

    elif(device_vendor=='Cisco'):
        try:
            driver = get_network_driver('nxos_ssh')
            device = driver(hostname=ip, username=username, password=password)
            getvlanaccessports()
        except:
            driver = get_network_driver('ios')
            device = driver(hostname=ip, username=username, password=password)
            getvlanaccessports()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        print('TESTING!')
        #config_commands = []
                            
except:
    
    print('Error!')
