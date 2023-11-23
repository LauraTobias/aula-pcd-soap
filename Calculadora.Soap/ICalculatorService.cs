﻿using System.ServiceModel;

namespace Calculadora.Soap
{
    [ServiceContract]
    public interface ICalculatorService
    {

        [OperationContract]
        double Add(double a, double b);

        [OperationContract]
        double Subtract(double a, double b);

        [OperationContract]
        double Multiply(double a, double b);

        [OperationContract]
        double Divide(double a, double b);
    }
}
