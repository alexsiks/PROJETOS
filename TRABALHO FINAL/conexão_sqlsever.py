import pyodbc
import os


string_conexao=["DESKTOP-KEIJ2RI","BIGDATA_2020","teste","123"]


conn = pyodbc.connect("Driver={SQL Server Native Client 11.0};Server="+string_conexao[0]+";"
"Database="+string_conexao[1]+";"
"UID="+string_conexao[2]+";"
"PWD="+string_conexao[3]+";")
 
    
def visualizar():
    os.system('cls')
    cursor = conn.cursor()
    cursor.execute("select id,nome,sexo from USUARIO where status = 1")
    for row in cursor:
        print(row)
    

def cadastrar():
    os.system('cls')
    nome = input("Informe um nome: ")
    sexo=input("Informe o sexo: ")
    os.system('cls')
    cursor = conn.cursor()
    cursor.execute("insert into usuario (nome,sexo,status) values ('"+nome+"','"+sexo+"',1)")    
    cursor.commit()
    visualizar() 

def desativar():
    os.system('cls')
    idusuario = int(input("Informe o id a ser desativado: "))
    os.system('cls')
    cursor = conn.cursor()
    cursor.execute("update usuario set status = 0 where id = "+idusuario)
    visualizar()
    cursor.commit() 


def menu():
    opcao=int(input(
    '''Informe uma opção valida: 
       VISUALIZAR DADOS:------------------[1]
       INSERIR DADOS----------------------[2]
       DELETAR DADOS----------------------[3]
       '''))
    if opcao == 1:
        visualizar()            
    elif opcao == 2:
        cadastrar()    
    elif opcao == 3:
        desativar()
    else:
        print("Opção invalida:")
        menu()    



#############------Menu de execução-----------##################
menu()



'''
COMANDO PARA VER O ID DO USUARIO N BANCO DE DADOS

 USE BIGDATA_2020  
SELECT USER_ID('teste');  
GO


'''