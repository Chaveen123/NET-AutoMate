from lxml import etree
import xml.etree.ElementTree as ET
from napalm import get_network_driver
import csv
import sys

def aristagetallvlan():
    #name = "10"
    #newname=name.replace(name,"Ethernet"+name)
    output = checkxml()

    tree = ET.fromstring(output)

    vlanid="data/network-instances/network-instance/vlans/vlan/vlan-id"
    
    newone = [vlanid]

    for x in newone:
        for target in tree.findall(x):
            print(target.text)   

def ciscogetallvlan():
    #name = "1"
    #newname=name.replace(name,"Ethernet"+name)
    output = checkxml()

    tree = ET.fromstring(output)

    vlanid="data/network-instances/network-instance/vlans/vlan[2]/vlan-id"
    
    newone = [vlanid]

    for x in newone:
        for target in tree.findall(x):
            print(target.text)   

def legacyciscogetallvlan():

    device.open()
    
    checkvlans = device.get_vlans()
    
    for x in checkvlans:
            print(x)
    
    device.close()

def junipergetallvlan():
    #name = "1"
    #newname=name.replace(name,"Ethernet"+name)
    output = checkxml()

    tree = ET.fromstring(output)

    vlanid="data/configuration/vlans/vlan/vlan-id"
    
    newone = [vlanid]

    for x in newone:
        for target in tree.findall(x):
            print(target.text)   

def aristavlan():
    #newname=name.replace(name,"Ethernet"+name)
    output = checkxml()

    tree = ET.fromstring(output)

    #vlanid="data/network-instances/network-instance/vlans/vlan[vlan-id='{new}']/vlan-id"
    vlanname="data/network-instances/network-instance/vlans/vlan[vlan-id='{new}']/config/name"
    #vlanint = "data/interfaces/interface[ethernet/switched-vlan/config/access-vlan='{new}']/name"
    vlanstatus="data/network-instances/network-instance/vlans/vlan[vlan-id='{new}']/config/status"

    vlanintip = "data/interfaces/interface[name='{new}']/routed-vlan/ipv4/addresses/address/config/ip"
    vlanintnet = "data/interfaces/interface[name='{new}']/routed-vlan/ipv4/addresses/address/config/prefix-length"
    
    newone = [vlanname,vlanstatus]

    for x in newone:
        newnww = x.format(new=name) 
        for target in tree.findall(newnww):
            print(target.text)
    
    check =name.replace(name,"Vlan"+name)

    checkip = vlanintip.format(new=check)
    x=tree.find(checkip)
    if(x==None):
        print("Not Configured!")
    else:
        print(x.text)
        
    checknet = vlanintnet.format(new=check)
    x=tree.find(checknet)
    if(x==None):
        print("Not Configured!")
    else:
        print(x.text)

def ciscovlan():
    #newname=name.replace(name,"Ethernet"+name)
    output = checkxml()

    tree = ET.fromstring(output)

    #vlanid="data/network-instances/network-instance/vlans/vlan[vlan-id='{new}']/vlan-id"
    vlanname="data/network-instances/network-instance/vlans/vlan[vlan-id='{new}']/config/name"
    vlanstatus="data/network-instances/network-instance/vlans/vlan[vlan-id='{new}']/config/status"
    
    newone = [vlanname,vlanstatus]

    for x in newone:
        newnww = x.format(new=name) 
        for target in tree.findall(newnww):
            print(target.text)

def legacyciscovlan():

    device.open()

    checkvlans = device.get_vlans()
    checkstat = device.get_interfaces() 
    checkint = device.get_interfaces_ip() 

    vlanint = name.replace(name,"Vlan"+name)
    
    try:
        vlanname = checkvlans[name]['name']
        print(vlanname)
    except:
        vlanname = checkvlans[int(name)]['name']
        print(vlanname)

    try:    
        vlanstatus = checkstat[vlanint]["is_up"]
        if(vlanstatus==True):
            print("ACTIVE")
        else:
            print("IN-ACTIVE")
    except:
        print("Not Configured!") 

    try:       
        vlanintip = checkint[vlanint]['ipv4']
        for x in vlanintip:
            print(x)
    except:
        print("Not Configured!")
    
    try:
        vlanintnet = checkint[vlanint]['ipv4'][x]['prefix_length']
        print(vlanintnet)
    except:
        print("Not Configured!")
    
    device.close()

def junipervlan():
    #newname=name.replace(name,"Ethernet"+name)
    output = checkxml()

    tree = ET.fromstring(output)

    checkname="data/configuration/vlans/vlan[vlan-id='{new}']/name"

    vlanname = checkname.format(new=name)
    x=tree.find(vlanname)
    print(x.text)

    device.open()

    checkstat = device.get_interfaces() 
    checkint = device.get_interfaces_ip() 
    
    vlanint = name.replace(name,"irb."+name)

    try:    
        vlanstatus = checkstat[vlanint]["is_up"]
        if(vlanstatus==True):
            print("ACTIVE")
        else:
            print("IN-ACTIVE")
    except:
        print("Not Configured!") 

    try:       
        vlanintip = checkint[vlanint]['ipv4']
        for x in vlanintip:
            print(x)
    except:
        print("Not Configured!")
    
    try:
        vlanintnet = checkint[vlanint]['ipv4'][x]['prefix_length']
        print(vlanintnet)
    except:
        print("Not Configured!")
    
    device.close()

#GETTING RID OF CONFIGURATION NAMESPACES IN XML
def checkxml():
    path = f"C:\\NETAutoMate\\Device_Configs\\DeviceConfig_{device_vendor}.xml"

    nons = etree.parse(path,parser=etree.XMLParser(recover=True))

    for elem in nons.getiterator():
        elem.tag = etree.QName(elem).localname

        etree.cleanup_namespaces(nons)

    output = etree.tostring(nons).decode()

    return output


#MAIN
####################################

#1 READ DEVICE COMPATIBILITY FILE
with open('C:\\NETAutoMate\\NETCONF_Compatible.txt','r') as devicecompatibility:
    compatibility = devicecompatibility.readline()

#2 READ DEVICE AUTHENTICATION FILE
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

#3 CHECK FOR ARGUMENTS AND RUN THE RESPECTIVE FUNCTION ACCORDINGLY
if len(sys.argv)>1:

    # GET SPECIFIC INTERFACE DETAILS
    name = sys.argv[1]

    if(compatibility == "NO"):
        if(device_vendor=="Cisco"):
            try:
                driver = get_network_driver('nxos_ssh')
                device = driver(hostname=ip, username=username, password=password)
                legacyciscovlan()
            except:
                driver = get_network_driver('ios')
                device = driver(hostname=ip, username=username, password=password)
                legacyciscovlan()
               
    elif(compatibility == "YES"):  
        if(device_vendor=="Cisco"):
            ciscovlan()

        elif(device_vendor=="Arista"):
            aristavlan()

        elif(device_vendor=="Juniper"):
            driver = get_network_driver('junos')   
            device = driver(hostname=ip, username=username, password=password) 
            junipervlan()
    
    #GET ALL INTERFACE NAMES
else:
    if(compatibility == "NO"):
        if(device_vendor=="Cisco"):
            try:
                driver = get_network_driver('nxos_ssh')
                device = driver(hostname=ip, username=username, password=password)
                legacyciscogetallvlan()
            except:
                driver = get_network_driver('ios')
                device = driver(hostname=ip, username=username, password=password)
                legacyciscogetallvlan()
                      
    elif(compatibility == "YES"):
        if(device_vendor=="Cisco"):
            ciscogetallvlan()

        elif(device_vendor=="Arista"):
            aristagetallvlan()

        elif(device_vendor=="Juniper"):
            driver = get_network_driver('junos') 
            device = driver(hostname=ip, username=username, password=password)
            junipergetallvlan()
