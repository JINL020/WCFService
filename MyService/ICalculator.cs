using System.ServiceModel;

namespace MyService

{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double num1, double num2);

        [OperationContract]
        double Subtract(double num1, double num2);
    }
}
