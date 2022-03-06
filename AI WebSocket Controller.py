import socket

TCP_IP = '127.0.0.1'
TCP_PORT = 35
MESSAGE = b"""coordinates: 41.728035,27.2121484
name: aria
health: 100/100
feelings: scared, worried"""

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((TCP_IP, TCP_PORT))
s.send(MESSAGE)
