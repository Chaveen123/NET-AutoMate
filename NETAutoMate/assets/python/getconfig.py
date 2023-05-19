import csv
import sys
from napalm import get_network_driver

configtype = sys.argv[1]

def getconfig():
    device.open()
    
    output = device.get_config()

    if(configtype == "running"):
        config = output['running']

    elif(configtype == "startup"):
        config = output['startup']
    
    print(config)

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
        getconfig()

    elif(device_vendor=='Cisco'):
        driver = get_network_driver('ios')
        device = driver(hostname=ip, username=username, password=password)
        getconfig()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        getconfig()
    
except Exception as e:
    
    print(f'Device was UNABLE to Retrieve Device Configuration. Please Retry!\nError: {e}')
