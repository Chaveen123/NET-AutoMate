import csv
import os
import datetime
from napalm import get_network_driver

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

def writelog(path,output):
    save = open(path,'w')
    save.write(str(output))
    save.close

def backupconfig():
    device.open()

    output = device.get_config()
    config = output['running']
    device.close()

    folder = 'C:\\NETAutoMate\\Device_Configs\\Config_Backups'

    file = f'DeviceConfigBackup_{device_vendor}_{ip}_{time_now}.conf'

    if not os.path.isdir(folder):
        os.makedirs(folder)
    
    path = os.path.join(folder,file)

    writelog(path=path,output=config)

    print('Device Configuration Saved SUCCESSFULLY!')
    print('Saved Configurations are available at C:\\NETAutoMate\\Device_Configs\\Config_Backups')

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
        backupconfig()

    elif(device_vendor=='Cisco'):
        driver = get_network_driver('ios')
        device = driver(hostname=ip, username=username, password=password)
        backupconfig()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        backupconfig()

except Exception as e:
    
    print(f'Device was UNABLE to Backup Device Configuration. Please Retry!\nError: {e}')
