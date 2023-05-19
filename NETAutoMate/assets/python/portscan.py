import socket
import threading
import concurrent.futures
import sys

ipaddress = sys.argv[1]
startport = sys.argv[2]
endport = sys.argv[3]

print_lock = threading.Lock()

def scan(ip,port):
    scanner = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
    scanner.settimeout(1)
    try:
        scanner.connect((ip,port))
        scanner.close()
        with print_lock:         
            print(f"Port {port} is Open on {ip}")
            print("------------------------------------------------------------")           
    except:
        pass

with concurrent.futures.ThreadPoolExecutor(max_workers=100) as executor:
    print("PORT SCANNER v1.0")
    print("------------------------------------------------------------") 
    print(f"Scanned Port Range {startport} - {endport}")
    print("------------------------------------------------------------") 
    for port in range(int(startport),int(endport)+1):
        executor.submit(scan,ipaddress,port)
