def desativar():
    os.system('cls')
    idusuario = int(input("Informe o id a ser desativado: "))
    os.system('cls')
    cursor = conn.cursor()
    cursor.execute("update usuario set status = 0 where id = "+idusuario)
    visualizar()
    cursor.commit() 