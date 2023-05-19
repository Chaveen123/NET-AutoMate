import csv
import time
from napalm import get_network_driver

def getdeviceinfo():
    device.open()

    facts = device.get_facts()
    
    device.close()

    newtime = time.strftime("%H hours %M minutes %S seconds",time.gmtime(facts['uptime'])) 

    print("DEVICE INFORMATION")
    print('--------------------------------------------------------------------------------')
    print(f"Vendor\t\t: {facts['vendor']}\nModel\t\t: {facts['model']}\nOS Version\t: {facts['os_version']}\nSerial Number\t: {facts['serial_number']}\nUptime\t\t: {newtime}")
    print('--------------------------------------------------------------------------------')
    print(f"FQDN\t\t: {facts['fqdn']}\nHostname  \t: {facts['hostname']}")
    print('--------------------------------------------------------------------------------\nInterface List\t:')

    for x in facts['interface_list']:
        print("\t\t  "+x)
    
    print('--------------------------------------------------------------------------------')

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
        getdeviceinfo()

    elif(device_vendor=='Cisco'):
        try:
            driver = get_network_driver('nxos_ssh')
            device = driver(hostname=ip, username=username, password=password)
            getdeviceinfo()
        except:
            driver = get_network_driver('ios')
            device = driver(hostname=ip, username=username, password=password)
            getdeviceinfo()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        getdeviceinfo()
    
except Exception as e:
    
    print(f'Device was UNABLE to Retrieve Device Information. Please Retry!\nError: {e}')