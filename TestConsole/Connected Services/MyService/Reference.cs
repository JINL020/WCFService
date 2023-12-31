﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsole.MyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        double Add(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtract", ReplyAction="http://tempuri.org/ICalculator/SubtractResponse")]
        double Subtract(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtract", ReplyAction="http://tempuri.org/ICalculator/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double num1, double num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : TestConsole.MyService.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<TestConsole.MyService.ICalculator>, TestConsole.MyService.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double num1, double num2) {
            return base.Channel.Add(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double num1, double num2) {
            return base.Channel.AddAsync(num1, num2);
        }
        
        public double Subtract(double num1, double num2) {
            return base.Channel.Subtract(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double num1, double num2) {
            return base.Channel.SubtractAsync(num1, num2);
        }
    }
}
