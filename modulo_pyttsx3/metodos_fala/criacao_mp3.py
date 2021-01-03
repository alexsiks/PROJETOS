
from gtts import gTTS

##Criando voz
voz = gTTS("modo segurança ativado, todos dispositivos de segurança ativos em sua casa.",lang='pt-br')
voz.save("modo_segurança.mp3")


