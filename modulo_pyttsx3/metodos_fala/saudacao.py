
from playsound import playsound
import os



def saudando():
        playsound('heloisa_saudacao.mp3')
    
def negando_opcao():
    playsound('heloisa_negando_opcao_menu.mp3')
def modo_seguranca():
    playsound('modo_segurança.mp3')


while True:

    os.system('cls')
    opcao=input('Informe uma opção:')
    
    if opcao == 'saudação':
        saudando()
    if opcao == 'segurança':
        modo_seguranca()
    else:
        negando_opcao()    

        
    