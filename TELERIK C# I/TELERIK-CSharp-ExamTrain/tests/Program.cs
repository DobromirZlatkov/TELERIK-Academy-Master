using System;

class XExpression
{
    static void Main()
    {
        string expression = Console.ReadLine();

        byte currentDigit = 0;
        double result = 0;
        char currentOperator = '\0';

        for (int i = 0; i < expression.Length - 1; i++)
        {
            if (char.IsDigit(expression[i])) // digit
            {
                currentDigit = byte.Parse(expression[i].ToString());

                switch (currentOperator)
                {
                    case '+':
                        result += currentDigit;
                        break;
                    case '-':
                        result -= currentDigit;
                        break;
                    case '*':
                        result *= currentDigit;
                        break;
                    case '/':
                        result /= currentDigit;
                        break;
                    default:
                        result = currentDigit;
                        break;
                }
            }
            else if (expression[i] != '(' &&
                expression[i] != ')') // operator
            {
                switch (expression[i])
                {
                    case '+':
                        currentOperator = '+';
                        break;
                    case '-':
                        currentOperator = '-';
                        break;
                    case '*':
                        currentOperator = '*';
                        break;
                    case '/':
                        currentOperator = '/';
                        break;
                    default:
                        currentOperator = '+';
                        break;
                }
            }
            else // bracket
            {
                byte innerDigit = 0;
                double innerResult = 0;
                char innerOperator = '\0';

                for (; expression[i] != ')'; i++)
                {
                    if (char.IsDigit(expression[i])) // digit
                    {
                        innerDigit = byte.Parse(expression[i].ToString());

                        switch (innerOperator)
                        {
                            case '+':
                                innerResult += innerDigit;
                                break;
                            case '-':
                                innerResult -= innerDigit;
                                break;
                            case '*':
                                innerResult *= innerDigit;
                                break;
                            case '/':
                                innerResult /= innerDigit;
                                break;
                            default:
                                innerResult = innerDigit;
                                break;
                        }
                    }
                    else if (expression[i] != '(' &&
                        expression[i] != ')') // operator
                    {
                        switch (expression[i])
                        {
                            case '+':
                                innerOperator = '+';
                                break;
                            case '-':
                                innerOperator = '-';
                                break;
                            case '*':
                                innerOperator = '*';
                                break;
                            case '/':
                                innerOperator = '/';
                                break;
                            default:
                                innerOperator = '+';
                                break;
                        }
                    }
                }

                switch (currentOperator)
                {
                    case '+':
                        result += innerResult;
                        break;
                    case '-':
                        result -= innerResult;
                        break;
                    case '*':
                        result *= innerResult;
                        break;
                    case '/':
                        result /= innerResult;
                        break;
                    default:
                        result = innerResult;
                        break;
                }
            }
        }

        Console.WriteLine("{0:0.00}", result);
    }
}