﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5483
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.5483.
// 
namespace SmartDeviceProject1.test {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="VehcileParkingHistorySoap", Namespace="http://tempuri.org/")]
    public partial class VehcileParkingHistory : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public VehcileParkingHistory() {
            this.Url = "http://localhost:33197/VehcileParkingHistory.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertVehcileParkingHistory", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int InsertVehcileParkingHistory(string VIN, string ParkingBay, string UserModified) {
            object[] results = this.Invoke("InsertVehcileParkingHistory", new object[] {
                        VIN,
                        ParkingBay,
                        UserModified});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginInsertVehcileParkingHistory(string VIN, string ParkingBay, string UserModified, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("InsertVehcileParkingHistory", new object[] {
                        VIN,
                        ParkingBay,
                        UserModified}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndInsertVehcileParkingHistory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
    }
}
