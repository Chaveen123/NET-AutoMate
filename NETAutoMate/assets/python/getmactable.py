import csv
from napalm import get_network_driver

def getmactable():
    device.open()

    mac = device.get_mac_address_table()
    
    device.close()

    print("MAC TABLE")
    print('--------------------------------------------------------------------------------')

    for mactable in mac:
        print(f"Mac Address\t: {mactable['mac']}\nInterface\t\t: {mactable['interface']}\nVLAN\t\t: {mactable['vlan']}\nStatic\t\t: {mactable['static']}\nStatus\t\t: {mactable['active']}\nMoves\t\t: {mactable['moves']}")
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
        getmactable()

    elif(device_vendor=='Cisco'):
        try:
            driver = get_network_driver('nxos_ssh')
            device = driver(hostname=ip, username=username, password=password)
            getmactable()
        except:
            driver = get_network_driver('ios')
            device = driver(hostname=ip, username=username, password=password)
            getmactable()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        getmactable()
       
except Exception as e:
    
    print(f'Device was UNABLE to Retrieve Device MAC Table. Please Retry!\nError: {e}')
