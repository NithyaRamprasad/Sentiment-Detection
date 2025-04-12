// See https://aka.ms/new-console-template for more information
using ML_project;

while (true)
{
    Console.WriteLine("Enter \n 1. to continue using model \n 2. Exit \n Please enter your input : ");
    var value = Console.ReadLine();
    switch(value)
    {
        case "1":   Console.WriteLine("Enter the text to check the sentiment : ");
                    var text = Console.ReadLine();
                    if(text != null)
                    {
                        //Load sample data
                        var sampleData = new SentimentModel.ModelInput()
                        {
                            Col0 = text,
                        };

                        //Load model and predict output
                        var result = SentimentModel.Predict(sampleData);

                        Console.WriteLine($"\n It is a {(result?.PredictedLabel == 1 ? "positive" : "negative")} statement.\n");
                    }
                    break;
        case "2":   Console.WriteLine("Exiting...");
                    return;
        default:    Console.WriteLine("Invalid Input. Please try again.\n");
                    break;
    };
}