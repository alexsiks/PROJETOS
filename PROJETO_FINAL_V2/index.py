import eel
import requests
import os


# Apontando para a pasta web onde estão os arquivos.
eel.init('web')

#Função para trazer arquivos do javascript.
@eel.expose                         
def out_javascript(x):
    print(f"Mensagem do servidor : {x}")

os.system('cls')


eel.start('index.html', size=(640, 480))  # Start












'''
------------------------------------------------------------------
#Função para trazer arquivos do javascript.
@eel.expose                         

def say_hello_py(x):
    print(f"Mensagem: {x}")
 ---------------------------------------------------------------------   
'''    