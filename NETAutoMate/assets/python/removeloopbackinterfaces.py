import datetime
from netmiko import ConnectHandler
import csv
import sys
import os

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

intname = sys.argv[1]
ipaddress = sys.argv[2]

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
        config_commands = [f'no interface {intname}']

    elif(netmiko=="arista_eos"):
        config_commands = [f'no interface {intname}']
   
    elif(netmiko=="juniper"):
        config_commands = [f'delete interfaces {intname}']
    
    net_connect.send_config_set(config_commands)
    
    if(netmiko=="juniper"):
        net_connect.commit()

    net_connect.disconnect()

    print(f'Loopback Interface {intname} Removed SUCCESSFULLY!')

except Exception as e:

    efolder = 'C:\\NETAutoMate\\Device_Logs\\LoopbackInterface_Logs'
    
    efile = f'LoopbackIntConfigERROR_{device_vendor}_{device_type}_{time_now}.log'
    
    if not os.path.isdir(efolder):
        os.makedirs(efolder)
        
    epath = os.path.join(efolder,efile)
    
    writelog(path=epath,output=e)
    
    print(f'System was UNABLE to Remove Loopback Interface {intname}. Please Retry!\nError: {e}')
