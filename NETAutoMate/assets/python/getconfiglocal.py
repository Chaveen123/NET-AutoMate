from ncclient import manager
import csv
import datetime
import os
from xml.dom import minidom

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p') 

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

            device = manager.connect(host=ip, port=830, username=username, password=password)
        
            output = minidom.parseString(device.get_config('running').xml).toprettyxml(indent = "  ")

    device.close_session()

    folder = 'C:\\NETAutoMate\\Device_Configs'
    
    file = f'DeviceConfig_{device_vendor}.xml'
    
    if not os.path.isdir(folder):
        os.makedirs(folder)
        
    path = os.path.join(folder,file)

    writelog(path=path,output=output)   

    print('Device Configuration Retrieved SUCCESSFULLY!')      

except Exception as e:

    efolder = 'C:\\NETAutoMate\\Device_Logs\\Authenticaton_Logs'
    
    efile = f'DeviceAuthERROR_{device_vendor}_{device_type}_{time_now}.log'
    
    if not os.path.isdir(efolder):
        os.makedirs(efolder)
        
    epath = os.path.join(efolder,efile)
    
    writelog(path=epath,output=e)

    print(f'System was UNABLE to Retrieve Device Configuration. Please Retry!\nError: {e}')


    
