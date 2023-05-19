from lxml import etree
import xml.etree.ElementTree as ET
from napalm import get_network_driver
import csv
import sys

#ARISTA GET ALL INTERFACE NAMES
def aristagetallint():

    intname = "data/interfaces/interface/config[type='ianaift:ethernetCsmacd']/name"

    getallint(intname=intname)
  
#CISCO GET ALL INTERFACE NAMES 
def ciscogetallint():

    intname = "data/interfaces[1]/interface/config[type='ianaift:ethernetCsmacd']/name"

    getallint(intname=intname)

#CISCO GET ALL INTERFACE NAMES - LEGACY
def legacyciscogetallint():

    device.open()
    
    allinterfaces = device.get_interfaces()
 
    for x in allinterfaces:
        if 'Loopback' in x:
            pass
        elif 'Vlan' in x:
            pass
        else:    
            print(x)
    
    device.close()

#JUNIPER GET ALL INTERFACE NAMES
def junipergetallint():

    #intname = "data/configuration/interfaces/interface[name!='lo0']/name"

    #getallint(intname=intname)

    device.open()

    allinterfaces = device.get_interfaces()
  
    for x in allinterfaces:
        if 'ge' in x:
            if '.' in x:
                pass
            else:    
                print(x)
        else:
            pass
    
    device.close()
    
#FUNCTION TO GET ALL INTERFACE NAMES
def getallint(intname):

    output = checkxml()
    
    tree = ET.fromstring(output)

    newone =[intname]
    for x in newone:      
        for target in tree.findall(x):
            print (target.text) 

#FUNCTION TO GET SPECIFIC INTERFACE DETAILS
def getint(intip,intnet,intstat):

    output = checkxml()

    tree = ET.fromstring(output)

    checkip = intip.format(new=name)
    x=tree.find(checkip)
    if(x==None):
        print("Not Configured!")
    else:
        print(x.text)

    checknet = intnet.format(new=name)
    x=tree.find(checknet)
    if(x==None):
        print("Not Configured!")
    else:
        print(x.text)
    
    checkstat = intstat.format(new=name)
    x=tree.find(checkstat)
    if(x==None):
        print("Not Configured!")
    else:
        if(x.text=="true"):
            print("Link Up")
        else:
            print("Link Down")

#ARISTA GET SPECIFIC INTERFACE DETAILS 
def aristaint():
 
    intip = "data/interfaces/interface[name='{new}']/subinterfaces/subinterface/ipv4/addresses/address/config/ip"
    intnet = "data/interfaces/interface[name='{new}']/subinterfaces/subinterface/ipv4/addresses/address/config/prefix-length"
    intstat = "data/interfaces/interface[name='{new}']/config/enabled"

    getint(intip=intip,intnet=intnet,intstat=intstat)

#CISCO GET SPECIFIC INTERFACE DETAILS 
def ciscoint():
 
    intip = "data/interfaces[1]/interface[name='{new}']/subinterfaces/subinterface/ipv4/addresses/address/config/ip"
    intnet = "data/interfaces[1]/interface[name='{new}']/subinterfaces/subinterface/ipv4/addresses/address/config/prefix-length"
    intstat = "data/interfaces[1]/interface[name='{new}']/config/enabled"

    getint(intip=intip,intnet=intnet,intstat=intstat)

#CISCO GET SPECIFIC INTERFACE DETAILS - LEGACY
def legacyciscoint():

    device.open()

    checkint = device.get_interfaces_ip()   
    checkstat = device.get_interfaces() 

    try:       
        intip = checkint[name]['ipv4']
        for x in intip:
            print(x)
    except:
        print("Not Configured!")
    
    try:
        intnet = checkint[name]['ipv4'][x]['prefix_length']
        print(intnet)
    except:
        print("Not Configured!")
    
    try:    
        instat = checkstat[name]["is_up"]
        if(instat==True):
            print("Link Up")
        else:
            print("Link Down")
    except:
        print("Not Configured!")

    device.close()

#JUNIPER GET SPECIFIC INTERFACE DETAILS 
def juniperint():    

    output = checkxml()

    tree = ET.fromstring(output)

    intdet = "data/configuration/interfaces/interface[name='{new}']/unit/family/inet/address/name"

    device.open()

    interfaces = device.get_interfaces()

    instat = interfaces[name]["is_up"]
    
    checkip = intdet.format(new=name)
    x=tree.find(checkip)
    if(x==None):
        print("Not Configured!")
        print("Not Configured!")

        if(instat==True):
            print("Link Up")
        else:
            print("Link Down")
        
    else:
        intip,intnet = x.text.split('/')
    
        print(intip)
        print(intnet)

        if(instat==True):
            print("Link Up")
        else:
            print("Link Down")
    
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
                legacyciscoint()
            except:
                driver = get_network_driver('ios')
                device = driver(hostname=ip, username=username, password=password)
                legacyciscoint()
               
    elif(compatibility == "YES"):  
        if(device_vendor=="Cisco"):
            ciscoint()

        elif(device_vendor=="Arista"):
            aristaint()

        elif(device_vendor=="Juniper"):
            driver = get_network_driver('junos')   
            device = driver(hostname=ip, username=username, password=password) 
            juniperint()
    
    #GET ALL INTERFACE NAMES
else:
    if(compatibility == "NO"):
        if(device_vendor=="Cisco"):
            try:
                driver = get_network_driver('nxos_ssh')
                device = driver(hostname=ip, username=username, password=password)
                legacyciscogetallint()
            except:
                driver = get_network_driver('ios')
                device = driver(hostname=ip, username=username, password=password)
                legacyciscogetallint()
                      
    elif(compatibility == "YES"):
        if(device_vendor=="Cisco"):
            ciscogetallint()

        elif(device_vendor=="Arista"):
            aristagetallint()

        elif(device_vendor=="Juniper"):
            driver = get_network_driver('junos') 
            device = driver(hostname=ip, username=username, password=password)
            junipergetallint()
    




















    







