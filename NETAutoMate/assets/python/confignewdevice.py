from jinja2 import Environment, FileSystemLoader
import sys
from netmiko import ConnectHandler
import serial

templatepath = sys.argv[1] #Not in Use
dvendor = sys.argv[2] #Not in Use
dtype = sys.argv[3]
hostname = sys.argv[4]
username = sys.argv[5]
password = sys.argv[6]
ipaddress = sys.argv[7]
subnetmask = sys.argv[8]
comport = sys.argv[9]

#COMMANDS SET FOR CISCO SWITCH
switchcommands=[f'hostname {hostname}',
                f'ip domain-name {username}',
                f'username {username} privilege 15 secret {password}',
                f'interface vlan 1',
                f'ip address {ipaddress} {subnetmask}',
                'no shutdown',
                'exit',
                'crypto key generate rsa modulus 1024',
                'line vty 0 4',
                'login local',
                'transport input ssh']

#COMMANDS SET FOR CISCO ROUTER
routercommands=[f'hostname {hostname}',
                f'ip domain-name {username}',
                f'username {username} privilege 15 secret {password}',
                f'interface gigabitEthernet 0/0',
                f'ip address {ipaddress} {subnetmask}',
                'no shutdown',
                'exit',
                'crypto key generate rsa modulus 1024',
                'line vty 0 4',
                'login local',
                'transport input ssh']
try:
    #env = Environment(loader = FileSystemLoader(templatepath), trim_blocks=True , lstrip_blocks=True)
    
    #template = env.get_template('template.j2')

    #output = template.render(dvendor=dvendor,dtype=dtype,hostname=hostname,username=username,password=password,vlanid="1",ipaddress=ipaddress,subnetmask=subnetmask)

    #print(output)

    net_connect = ConnectHandler(device_type="cisco_ios_serial",fast_cli=False,serial_settings={'port': comport,'baudrate': 9600,'bytesize': serial.EIGHTBITS,'parity': serial.PARITY_NONE,'stopbits': serial.STOPBITS_ONE})

    net_connect.enable()

    #Note: Template tested, but not executing all commands.
    #Workaround: Defined all commands sets in seperate arrays.

    if dtype == "Switch":
        net_connect.send_config_set(config_commands=switchcommands)
    elif dtype == "Router":
        net_connect.send_config_set(config_commands=routercommands)
    
    net_connect.disconnect()

    print(f'New {dvendor} {dtype} Configured SUCCESSFULLY!')
        
except Exception as e:
    
    print(f'System was UNABLE to Configure the New {dvendor} {dtype}. Please Retry!\nError: {e}')
