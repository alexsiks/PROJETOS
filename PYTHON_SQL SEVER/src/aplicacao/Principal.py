import Principal
import pyodbc
import os
import modulos

os.system('cls')

string_conexao=["DESKTOP-KEIJ2RI","ESTACAO_MUSICAL_BH","user","123"]


conn = pyodbc.connect("Driver={SQL Server Native Client 11.0};Server="+string_conexao[0]+";"
"Database="+string_conexao[1]+";"
"UID="+string_conexao[2]+";"
"PWD="+string_conexao[3]+";")
 
    
def menu():
    opcao=int(input('''
       *************************************** 
       *       INSIRA UMA OPÇÃO VALIDA       *
       ***************************************

       
       VISUALIZAR DADOS:------------------[1]
       INSERIR DADOS----------------------[2]
       DELETAR DADOS----------------------[3]
       
       INSIRA: '''))

    if opcao == 1:
        visualizar()            
    elif opcao == 2:
        cadastrar()    
    elif opcao == 3:
        desativar()
    else:
        os.system('cls')
        print("\n\nOpção invalida:\n\n")
        menu()



#############------Menu de execução-----------##################
menu()



'''
COMANDO PARA VER O ID DO USUARIO N BANCO DE DADOS

 USE BIGDATA_2020  
SELECT USER_ID('teste');  
GO


'''