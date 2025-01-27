using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var textEditor = new TextEditor();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;

            string[] command = input.Split(' ');
            int commandType = int.Parse(command[0]);

            switch (commandType)
            {
                case 1:
                    textEditor.Append(command[1]);
                    break;
                case 2:
                    int count = int.Parse(command[1]);
                    textEditor.Erase(count);
                    break;
                case 3:
                    int index = int.Parse(command[1]);
                    char result = textEditor.Get(index);
                    Console.WriteLine(result);
                    break;
                case 4:
                    textEditor.Undo();
                    break;
            }
        }
    }
}

class TextEditor
{
    private string currentText;
    private Stack<Operation> operations;

    public TextEditor()
    {
        currentText = "";
        operations = new Stack<Operation>();
    }

    public void Append(string str)
    {
        operations.Push(new Operation(OperationType.Append, str));
        currentText += str;
    }

    public void Erase(int count)
    {
        string erasedText = currentText.Substring(currentText.Length - count);
        operations.Push(new Operation(OperationType.Erase, erasedText));
        currentText = currentText.Substring(0, currentText.Length - count);
    }

    public char Get(int index)
    {
        return currentText[index - 1];
    }

    public void Undo()
    {
        if (operations.Count == 0)
            return;

        Operation lastOperation = operations.Pop();

        if (lastOperation.Type == OperationType.Append)
        {
            currentText = currentText.Substring(0, currentText.Length - lastOperation.Text.Length);
        }
        else 
        {
            currentText += lastOperation.Text;
        }
    }
}

class Operation
{
    public OperationType Type { get; }
    public string Text { get; }

    public Operation(OperationType type, string text)
    {
        Type = type;
        Text = text;
    }
}

enum OperationType
{
    Append,
    Erase
}