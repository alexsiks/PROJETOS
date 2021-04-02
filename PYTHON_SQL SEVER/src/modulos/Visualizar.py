def visualizar():
    os.system('cls')
    cursor = conn.cursor()
    cursor.execute("select id,nome,sexo from USUARIO where status = 1")
    for row in cursor:
        print(row)