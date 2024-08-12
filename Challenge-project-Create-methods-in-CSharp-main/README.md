# Challenge-project-Create-methods-in-CSharp

Starter and Final code for the Challenge project: "Create methods C# console applications" from the Microsoft Learn collection "Getting started with C#"

Pour répondre à vos exigences, voici comment vous pouvez mettre à jour votre code en C# :

1. **Détection du redimensionnement du terminal** :
   - Déterminer si le terminal a été redimensionné avant de continuer le jeu.
   - Effacer la console et terminer le jeu si le terminal a été redimensionné.
   - Afficher le message "Console was resized. Program exiting." avant de terminer le programme.

2. **Ajout d'un arrêt facultatif** :
   - Modifier la méthode existante `Move` pour prendre en charge un paramètre facultatif.
   - Si ce paramètre est activé, détecter l'entrée d'une touche non directionnelle.
   - Si une entrée non directionnelle est détectée, autoriser le jeu à s'arrêter.

Pour vérifier que votre code répond aux exigences spécifiées, procédez comme suit :

1. **Testez le redimensionnement du terminal** : Lancez le programme et redimensionnez la fenêtre du terminal pour vérifier que le jeu s'arrête et affiche le message approprié.
2. **Testez l'arrêt facultatif** : Appelez la méthode `Move` avec le paramètre `detectNonDirectionalKey` défini sur `true` et vérifiez que le jeu s'arrête lorsqu'une touche non directionnelle est entrée.
Voici un exemple de code mis à jour :

```csharp
using System;
using System.Threading;

class Program
{
    static bool gameRunning = true;
    static int initialWidth = Console.WindowWidth;
    static int initialHeight = Console.WindowHeight;

    static void Main()
    {
        // Abonnez-vous à l'événement de redimensionnement de la fenêtre
        Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
        Thread windowSizeThread = new Thread(CheckWindowSize);
        windowSizeThread.Start();

        while (gameRunning)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key != ConsoleKey.UpArrow && key != ConsoleKey.DownArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.RightArrow)
                {
                    Console.WriteLine("Caractère non directionnel entré. Arrêt du jeu.");
                    gameRunning = false;
                }
            }
        }

        windowSizeThread.Join();
    }

    static void CheckWindowSize()
    {
        while (gameRunning)
        {
            if (Console.WindowWidth != initialWidth || Console.WindowHeight != initialHeight)
            {
                Console.Clear();
                Console.WriteLine("Console was resized. Program exiting.");
                gameRunning = false;
            }
            Thread.Sleep(100);
        }
    }

    static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
    {
        e.Cancel = true;
        gameRunning = false;
    }

    static void Move(bool detectNonDirectionalKey = false)
    {
        if (detectNonDirectionalKey && Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            if (key != ConsoleKey.UpArrow && key != ConsoleKey.DownArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.RightArrow)
            {
                Console.WriteLine("Caractère non directionnel entré. Arrêt du jeu.");
                gameRunning = false;
            }
        }
    }
}
```