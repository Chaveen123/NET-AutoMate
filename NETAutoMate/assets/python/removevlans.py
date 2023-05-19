import datetime
from netmiko import ConnectHandler
from napalm import get_network_driver
import csv
import sys
import os

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

vlanid = sys.argv[1]
vlanname = sys.argv[2]

def writelog(path,output):
    save = open(path,'w')
    save.write(str(output))
    save.close

def removevlans():
    device.open()

    vlans = device.get_vlans()
                       
    if(netmiko=="cisco_ios"):
        removevlan = [f'no vlan {vlanid}',f'no interface vlan {vlanid}']
        net_connect.send_config_set(removevlan)

        for x in vlans:
            if x ==vlanid:
                for y in vlans[x]['interfaces']:                      
                        if 'Cpu' in y:
                            pass
                        else:
                            removevlanaccessport = [f'interface {y}',f'no switchport access vlan {vlanid}']
                            net_connect.send_config_set(removevlanaccessport) 

    elif(netmiko=="arista_eos"):
        removevlan = [f'no vlan {vlanid}',f'no interface vlan {vlanid}']
        net_connect.send_config_set(removevlan)

        for x in vlans:
            if x ==vlanid:
                for y in vlans[x]['interfaces']:                      
                        if 'Cpu' in y:
                            pass
                        else:
                            removevlanaccessport = [f'interface {y}',f'no switchport access vlan {vlanid}']
                            net_connect.send_config_set(removevlanaccessport)  

    elif(netmiko=="juniper"):
        removevlan = [f'delete security zones security-zone trust interfaces irb.{vlanid}',f'delete interfaces irb unit {vlanid}',f'delete vlans {vlanname}']
        net_connect.send_config_set(removevlan)
        net_connect.commit()
    
    net_connect.disconnect()

    device.close()

    print (f'VLAN {vlanid} Removed SUCCESSFULLY!')

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

    enable = net_connect.enable()

    if(device_vendor=='Arista'):    
        driver = get_network_driver('eos')
        device = driver(hostname=ip, username=username, password=password, optional_args={'transport':'http'})
        removevlans()

    elif(device_vendor=='Cisco'):
        try:
            driver = get_network_driver('nxos_ssh')
            device = driver(hostname=ip, username=username, password=password)
            removevlans()
        except:
            driver = get_network_driver('ios')
            device = driver(hostname=ip, username=username, password=password)
            removevlans()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        removevlans()
    
except Exception as e:

    efolder = 'C:\\NETAutoMate\\Device_Logs\\VLANInterface_Logs'

    efile = f'VLANConfigERROR_{device_vendor}_{device_type}_{time_now}.log'

    if not os.path.isdir(efolder):
        os.makedirs(efolder)
    
    epath = os.path.join(efolder,efile)
    
    writelog(path=epath,output=e)
    
    print(f'System was UNABLE to Remove VLAN {vlanid}. Please Retry!\nError: {e}')
