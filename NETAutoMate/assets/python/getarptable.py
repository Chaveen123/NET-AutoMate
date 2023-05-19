import csv
from napalm import get_network_driver

def getarptable():
    device.open()

    arp = device.get_arp_table()
    
    device.close()

    print("ARP TABLE")
    print('--------------------------------------------------------------------------------')

    for arptable in arp:
        print(f"Interface\t\t: {arptable['interface']}\nMac Address\t: {arptable['mac']}\nIP Address  \t: {arptable['ip']}\nAge (min)  \t: {int(arptable['age'])}")
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
        getarptable()

    elif(device_vendor=='Cisco'):
        try:
            driver = get_network_driver('nxos_ssh')
            device = driver(hostname=ip, username=username, password=password)
            getarptable()
        except:
            driver = get_network_driver('ios')
            device = driver(hostname=ip, username=username, password=password)
            getarptable()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        getarptable()
    
except Exception as e:
    
    print(f'Device was UNABLE to Retrieve Device ARP Table. Please Retry!\nError: {e}')
