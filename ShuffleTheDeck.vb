'Kendall Callister
'RCET0265
'Spring 2021
'Shuffle The Deck
'

Option Explicit On
Option Strict On

Module ShuffleTheDeck

    Sub Main()
        Dim cardCount As Integer = 52
        Dim deck(3, 12) As String
        Dim run As Boolean = True
        Dim userInput As String
        Dim card As String

        Randomize()
        Console.WriteLine("Hit Enter to Draw Card.")
        Console.WriteLine("Enter shuffle to shuffle the deck.")
        Console.WriteLine("Enter q to quit program")
        deck = Shuffle()

        'Loops program until it is told to stop
        While run = True
            userInput = Console.ReadLine()
            Select Case userInput

                'User selects to draw crad
                Case = String.Empty
                    card = Draw(deck)
                    cardCount -= 1
                    Console.WriteLine(card + vbTab + $"{cardCount}")
                    If cardCount = 0 Then
                        deck = Shuffle()
                        cardCount = 52
                    End If
                'User shuffles the deck
                Case = "shuffle"
                    deck = Shuffle()
                    cardCount = 52
                'Ends the loop
                Case = "q"
                    run = False
                Case Else
                    Console.WriteLine("Invaild Input")
            End Select

        End While
    End Sub

    'Refills the Matrix with the Card Values
    Function Shuffle() As String(,)
        Dim deck = New String(3, 12) {{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q",
            "K", "A"}, {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"},
            {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"},
            {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"}}
        Return deck
    End Function

    'Retrieves a random card value that hasn't been chosen
    Function Draw(ByRef drawPile(,) As String) As String
        Dim newCard As Boolean
        Dim card As String
        Dim cardValue As Integer
        Dim cardSuit As Integer

        While newCard = False
            cardValue = CInt(Rnd() * 12)
            cardSuit = CInt(Rnd() * 3)
            card = drawPile(cardSuit, cardValue)

            'See if the card has already been choosen
            If card = "0" Then
                newCard = False
                'Clears card from the matrix and tells it what suit it is.
            Else
                newCard = True
                drawPile(cardSuit, cardValue) = "0"
                Select Case cardSuit
                    Case = 0
                        card = $"{card} of Spade"
                    Case = 1
                        card = $"{card} of Clubs"
                    Case = 2
                        card = $"{card} of Hearts"
                    Case = 3
                        card = $"{card} of Diamonds"
                End Select
            End If
        End While
        Return card
    End Function
End Module
