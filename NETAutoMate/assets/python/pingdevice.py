import json
from lib2to3.pgen2.token import INDENT
import datetime
import csv
import sys
import os
from napalm import get_network_driver

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

pingip = sys.argv[1]

def writelog(path,output):
    save = open(path,'w')
    save.write(str(output))
    save.close

def pingdevice():
    device.open()

    ping_remote_ip = device.ping(pingip)

    if ping_remote_ip['success']: 
        print("PING RESULTS")
        print('--------------------------------------------------------------------------------')      
        print(f"Packet Loss\t: {ping_remote_ip['success']['packet_loss']}\nProbes Sent\t: {ping_remote_ip['success']['probes_sent']}\nResults\t\t:")

        for x in ping_remote_ip['success']['results']:
            print(f"\t\t  IP: {x['ip_address']}\tRTT: {x['rtt']}")
        
        print(f"\nAverage RTT\t: {ping_remote_ip['success']['rtt_avg']}\nMaximum RTT\t: {ping_remote_ip['success']['rtt_max']}\nMinimum RTT\t: {ping_remote_ip['success']['rtt_min']}\nStd. Deviation RTT\t: {ping_remote_ip['success']['rtt_stddev']}")

    print('--------------------------------------------------------------------------------')
    print('Logs are available at C:\\NETAutoMate\\Device_Logs\\Ping_Logs')
       
    device.close()

    folder = 'C:\\NETAutoMate\\Device_Logs\\Ping_Logs'

    file = f'PingedDevice_{ip}_{time_now}.log'

    if not os.path.isdir(folder):
        os.makedirs(folder)
    
    path = os.path.join(folder,file)

    writelog(path=path,output=json.dumps(ping_remote_ip['success'],indent=4,sort_keys=True))

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
        pingdevice()

    elif(device_vendor=='Cisco'):
        try:
            driver = get_network_driver('nxos_ssh')
            device = driver(hostname=ip, username=username, password=password)
            pingdevice()
        except:
            driver = get_network_driver('ios')
            device = driver(hostname=ip, username=username, password=password)
            pingdevice()
    
    elif(device_vendor=='Juniper'):
        driver = get_network_driver('junos')
        device = driver(hostname=ip, username=username, password=password)
        pingdevice()
        
except Exception as e:

    print(f'Device was UNABLE to Ping {ip}. Please Retry!\nError: {e}')