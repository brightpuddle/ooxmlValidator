using System;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;

static void ValidateWordDocument(string filepath)
{
    using (
        WordprocessingDocument wordprocessingDocument = WordprocessingDocument.Open(filepath, true)
    )
    {
        try
        {
            OpenXmlValidator validator = new OpenXmlValidator();
            int count = 0;
            foreach (ValidationErrorInfo error in validator.Validate(wordprocessingDocument))
            {
                count++;
                Console.WriteLine("Error " + count);
                Console.WriteLine("Description: " + error.Description);
                Console.WriteLine("ErrorType: " + error.ErrorType);
                Console.WriteLine("Node: " + error.Node);
                Console.WriteLine("Path: " + error.Path.XPath);
                Console.WriteLine("Part: " + error.Part.Uri);
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("count={0}", count);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        wordprocessingDocument.Close();
    }
}

if (args.Length > 0)
{
    ValidateWordDocument(args[0]);
}
