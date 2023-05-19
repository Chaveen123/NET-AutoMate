from getmac import get_mac_address
from mac_vendor_lookup import MacLookup
import sys

ipaddress = sys.argv[1]

try:
    mac = get_mac_address(ip=ipaddress)

    vendor = MacLookup().lookup(mac)

    print(vendor)

except Exception as e:
     
    print(f'System was UNABLE to Verify the Device MAC Address of IP: {ipaddress}. Please Retry!\n\nVendor Lookup Requires Internet Connectivity and a Valid IP Address in the Network.')


