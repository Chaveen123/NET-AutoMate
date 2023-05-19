import datetime
from netmiko import ConnectHandler
import csv
import sys
import os
from netaddr import IPAddress

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

vlanid = sys.argv[1]
vlanname = sys.argv[2]
vlanip = sys.argv[3]
vlanmask = sys.argv[4]
prefixlength = IPAddress(str(vlanmask)).netmask_bits()
interface = sys.argv[5]

def writelog(path,output):
    save = open(path,'w')
    save.write(str(output))
    save.close

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

    if(netmiko=="cisco_ios"):
        config_commands = [f'vlan {vlanid}',f'name {vlanname}','exit',f'interface vlan {vlanid}',f'ip address {vlanip} {vlanmask}','no shutdown','exit',f'interface {interface}','switchport','switchport mode access',f'switchport access vlan {vlanid}','no shutdown']

    elif(netmiko=="arista_eos"):
        config_commands = [f'vlan {vlanid}',f'name {vlanname}','exit',f'interface vlan {vlanid}',f'ip address {vlanip} {vlanmask}','no shutdown','exit',f'interface {interface}','switchport','switchport mode access',f'switchport access vlan {vlanid}','no shutdown']
   
    elif(netmiko=="juniper"):
        config_commands = [f'delete interfaces {interface} unit 0 family inet',f'set vlans {vlanname} vlan-id {vlanid} l3-interface irb.{vlanid}',f'set interfaces irb unit {vlanid} family inet address {vlanip}/{prefixlength}',f'set interfaces {interface} unit 0 family ethernet-switching vlan members {vlanname}',f'set security zones security-zone trust interfaces irb.{vlanid} host-inbound-traffic system-services all']
        
    net_connect.send_config_set(config_commands)    

    if(netmiko=="juniper"):
        net_connect.commit()
        
    net_connect.disconnect()

    print (f'VLAN Created SUCCESSFULLY!\nVLAN ID: {vlanid} | VLAN Name: {vlanname} | VLAN IP Address: {vlanip}')

except Exception as e:

    efolder = 'C:\\NETAutoMate\\Device_Logs\\VLANInterface_Logs'
    
    efile = f'VLANConfigERROR_{device_vendor}_{device_type}_{time_now}.log'

    if not os.path.isdir(efolder):
        os.makedirs(efolder)
    
    epath = os.path.join(efolder,efile)
    
    writelog(path=epath,output=e)
    
    print(f'System was UNABLE to Create VLAN {vlanid}. Please Retry!\nError: {e}')
