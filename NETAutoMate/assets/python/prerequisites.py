import datetime
from netmiko import ConnectHandler
from napalm import get_network_driver
import csv
import os

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

def writelog(path,output):
    save = open(path,'w')
    save.write(str(output))
    save.close

def juniperportsec():
    driver = get_network_driver('junos')
    
    device = driver(hostname=ip, username=username, password=password)
    
    device.open()

    checkint = device.get_interfaces()

    device.close()

    for int in checkint:
        if 'ge' in int:
            if '.' in int:
                pass
            else:    
                config_commands = [f'set interfaces {int} unit 0']
                net_connect.send_config_set(config_commands)
        else:
            pass

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

    net_connect = ConnectHandler(device_type=netmiko,ip=ip,username=username,password=password)

    net_connect.enable()

    if(netmiko=="cisco_ios"):
        config_commands = ['ip scp server enable','no banner exec','no banner incoming','no banner login','feature scp','feature nxapi']

    elif(netmiko=="arista_eos"):
        config_commands = ['management api netconf','transport ssh TEST','exit','management api http-commands','no shutdown','protocol http']
   
    elif(netmiko=="juniper"):
        #juniperportsec()
        config_commands = ['set system services ssh','set system services netconf ssh']
    
    net_connect.send_config_set(config_commands)
        
    if(netmiko=="juniper"):
        net_connect.commit()
    else:
        net_connect.send_command('write')

    net_connect.disconnect()

    print ('Prerequisites have been Configured SUCCESSFULLY!')

except Exception as e:

    efolder = 'C:\\NETAutoMate\\Device_Logs\\Prerequisites_Logs'

    efile = f'PrerequisitesConfigERROR_{device_vendor}_{device_type}_{time_now}.log'

    if not os.path.isdir(efolder):
        os.makedirs(efolder)
    
    epath = os.path.join(efolder,efile)
    
    writelog(path=epath,output=e)
    
    print(f'System was UNABLE to Configure the Prerequisites. Please Check Authentication Details!\nError: {e}')
