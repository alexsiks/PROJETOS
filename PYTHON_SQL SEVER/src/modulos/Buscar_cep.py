'''
import requests

x = requests.get('https://w3schools.com')
print(x.status_code)
'''
from requests.models import Request
import os

def consulta_cep(cep):
    import requests
    response = requests.get('https://viacep.com.br/ws/'+cep+'/json/')
    print(response.text)

os.system('cls')
cep_informado=input('Informe o cep: ')

consulta_cep(cep_informado)    


