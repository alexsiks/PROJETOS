
import speech_recognition as sr



#reconhecedor
recognizer = sr.Recognizer()


with sr.Microphone() as source:
    audio = recognizer.recognize.listen(source)

    print(recognizer.recognize_sphinx(audio))
