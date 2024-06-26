# 12-endabgabefizzbuzz-ekoegl

### Einführung und Spielbeschreibung:

* Das Spiel gibt eine **Zahl im Bereich zischen 1 und 1000** aus und man muss bestimmen, ob diese Zahl durch 3 und/oder durch 5 teilbar ist. 
* Für jede der **4 möglichen Antworten** (Fizz, Buzz, FizzBuzz und nicht teilbar) gibt es eine bestimmte Eingabetaste, die der Spieler drücken muss. 
* Danach wird der Spieler darüber informiert ob seine Antwort **richtig oder falsch** war. 
* Nun kann er mit der bestimmten Eingabetaste eine **neue Zahl** generieren. 
* Ziel ist es **spielerisch die Rechenregeln zu lernen** und klar zu erkennen ob die  Antwort des Spielers richtig oder falsch war.


### Spielanleitung:

* Nach dem Start des Spieles, überlegt sich der Spieler die richtige Antwort.
* Wenn die Zahl durch 3 teilbar ist, drückt er die **linke Pfeiltaste für Fizz** (Löffel berühren bei Makey Makey).
* Wenn die Zahl durch 5 teilbar ist, drückt er die **rechte Pfeiltaste für Buzz** (Gabel berühren bei Makey Makey).
* Wenn die Zahl durch 3 UND durch 5 teilbar ist, drückt er die **obere Pfeiltaste für FizzBuzz** (Orange berühren bei Makey Makey).
* Wenn die Zahl **nicht durch 3 oder 5 teilbar** ist drückt er die **untere Pfeiltaste** (Apfel berühren bei Makey Makey).
* Nun wird dem Spieler gesagt ob er **„Correct“** oder **„Incorrect“** geantwortet hat.
* Mit der **space Taste** (Wasser berühren bei Makey Makey) kann der Spieler jetzt eine **neue Zahl generieren**, die ihm direkt angezeigt wird.  


### Analyse Fragebogen:

_Tester: 8 Jährige, 49 Jährige und 50 Jähriger_

Die Fizz Buzz App wurde insgesamt positiv bewertet, insbesondere die **Benutzerfreundlichkeit** und das **klare Feedback** im Spiel wurden hervorgehoben. Die Anweisungen und Hinweise im Spiel wurden ebenfalls als hilfreich empfunden. Allen Testern hat das Spiel gut gefallen und sie fanden es **sehr unterhaltsam**, trotz verschiedener Altersgruppen. Insgesamt gibt es **keine Berichte über Fehler oder Abstürze**, was auf eine **stabile App** hinweist.
Diese Analyse zeigt, dass die Fizz Buzz App sowohl für junge als auch ältere Nutzer geeignet ist und effektiv dabei hilft, die **Multiplikationsreihen** von 3 und 5 zu üben.


```mermaid
classDiagram

    class InteractiveManager {
        + randomNbr: TMP_Text
        + right: Image
        + wrong: Image
        + correct: TMP_Text
        + incorrect: TMP_Text
        + bunnyhappy: Image
        + bunnysad: Image
        + audioright: AudioSource
        + audiowrong: AudioSource
        - randomNumber: int

        - Start() void
        - GenerateNumber() void
        - Right() void
        - Wrong() void
        - Update() void
    }

    class TMP_Text
    class Image
    class AudioSource
    class MonoBehaviour

    InteractiveManager --|> MonoBehaviour
    InteractiveManager -- TMP_Text : randomNbr
    InteractiveManager -- Image : right
    InteractiveManager -- Image : wrong
    InteractiveManager -- TMP_Text : correct
    InteractiveManager -- TMP_Text : incorrect
    InteractiveManager -- Image : bunnyhappy
    InteractiveManager -- Image : bunnysad
    InteractiveManager -- AudioSource : audioright
    InteractiveManager -- AudioSource : audiowrong
    

    TMP_Text : string text
    Image : bool enabled
    AudioSource : bool enabled
    ```
