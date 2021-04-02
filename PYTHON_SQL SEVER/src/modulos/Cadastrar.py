def cadastrar():
    os.system('cls')
    nome = input("Informe um nome: ")
    sexo=input("Informe o sexo: ")
    os.system('cls')
    cursor = conn.cursor()
    cursor.execute("insert into usuario (nome,sexo,status) values ('"+nome+"','"+sexo+"',1)")    
    cursor.commit()
    visualizar() 