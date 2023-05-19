import datetime
from netmiko import ConnectHandler
import socket
import struct
import os
import sys

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

targetvendor = sys.argv[1]
targetip = sys.argv[2]
targetusername = sys.argv[3]
targetpassword = sys.argv[4]
vlanid = sys.argv[5]
vlanname = sys.argv[6]
vlanip = sys.argv[7]
vlanprefix = sys.argv[8]

def vlanmask(prefix):
    host_bits = 32 - int(prefix)
    netmask = socket.inet_ntoa(struct.pack('!I', (1 << 32) - (1 << host_bits)))
    return netmask

def writelog(path,output):
    save = open(path,'w')
    save.write(str(output))
    save.close

try:
    if(targetvendor == "Cisco"):
        netmiko = "cisco_ios"
    elif(targetvendor == "Arista"):
        netmiko = "arista_eos"
    elif(targetvendor == "Juniper"):
        netmiko = "juniper"

    net_connect = ConnectHandler(device_type=netmiko,ip=targetip,username=targetusername,password=targetpassword)

    enable = net_connect.enable()

    if(netmiko=="cisco_ios"):
        config_commands = [f'vlan {vlanid}',f'name {vlanname}','exit',f'interface vlan {vlanid}',f'ip address {vlanip} {vlanmask(vlanprefix)}','no shutdown']

    elif(netmiko=="arista_eos"):
        config_commands = [f'vlan {vlanid}',f'name {vlanname}','exit',f'interface vlan {vlanid}',f'ip address {vlanip} {vlanmask(vlanprefix)}','no shutdown']
   
    elif(netmiko=="juniper"):
        config_commands = [f'set vlans {vlanname} vlan-id {vlanid} l3-interface irb.{vlanid}',f'set interfaces irb unit {vlanid} family inet address {vlanip}/{vlanprefix}',f'set security zones security-zone trust interfaces irb.{vlanid} host-inbound-traffic system-services all']
        
    net_connect.send_config_set(config_commands)

    if(netmiko=="juniper"):
        net_connect.commit()    
        
    net_connect.disconnect()

    print (f'VLAN Created SUCCESSFULLY in Target Device!\nVLAN ID: {vlanid} VLAN Name: {vlanname}')

except Exception as e:

    efolder = 'C:\\NETAutoMate\\Device_Logs\\TranslateVLANInterface_Logs'

    efile = f'TranslateVLANConfigERROR_{targetvendor}_Switch_{time_now}.log'

    if not os.path.isdir(efolder):
        os.makedirs(efolder)
    
    epath = os.path.join(efolder,efile)
    
    writelog(path=epath,output=e)
    
    print(f'System was UNABLE to Create VLAN {vlanid}. Please Retry!\nError: {e}')
