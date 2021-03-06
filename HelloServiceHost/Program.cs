﻿using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace HelloServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                ServiceMetadataBehavior metaDataBehaviour = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true
                };
                host.Description.Behaviors.Add(metaDataBehaviour);
                host.AddServiceEndpoint(typeof(HelloService.IHelloServiceChanged), new BasicHttpBinding(), "HelloService");
                host.Open();

                System.Console.WriteLine("Host Started" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}

/*
 * Now we are creating a host which will host this WCF Service
 * for that in the  separate console application we need to add the DLL of the WCF Service created in lst commit
 * and also we need to add refernce of system.serviceModdel
 * SO here our aim is to host the service via this console application, we want to create two end points. so let's change the
 * config file.
 * 
 * 
 * Its all little tough but you will get eventually used to it. For now I had to run the host in Administrator Mode.
 * 
 * Now if we go to localhost:8080 it will open a link where we can see the WSDL document
 * This wsdl document is used by client to know what are the services available.
 * if you see the app.config file we have added one addredd as "mex" and that one is responsible for WSDL stuff
 * Client creattes proxy class based onm that wsdl info to communicate with the host.
 * 
 * 
 * There are many ways to host a WCF Service
 * a. Self-Hosting: using some console application the way we have been doing in previous tutoriaLS
 * b. Windows Service: Hosting using a Windows Service
 * c. IIS:
 * d. WAS: Windows Activation Service:
 * 
 * What are Windows Services:
 * They run in the background
 * they can be configured to start during system bootup
 * they don't have user interface
 * to see the windows services just run services.msc
 * When we should create a windows service when we want some action to get started w/o any user interaction and as soon as the system boots up
 *
 */




