﻿namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}


/*
 * How to host a WCF service in IIS
 * 1. Create a normal service the way you do all the time. ex: HelloService
 * 2. We need to host it to IIS for that we need to add a web site. SO go the solution and right click and DO NOT click on add new project
 * rather click on "New Web Site" their click on the WCF Service and important that we create the website at the same place where the
 * overall solution is located.ex: HelloServiceIIS. Delete the stuff from APP_Code. nOW ADD REFeferece of service to this IIS HOsting website.
 * Now double click on the svc file and then delete the code behind tag and then add the reference of our service in the ServiceTag. ex: HelloService.HelloService
 * this is the place where we are actually linkikng the IIS Website to the Service. so ths is importnat.
 * Now delete the content of web.config file and add the the content in cofig file from any of the other hosting services in this solution
 * Also, we need to keep just one metadataexchange base addrtess. anything welse needs to be deleted. and make the binding as basicHttpBinding
 * 
 * Now we need to add this WebSite in IIS. If you dont have IIS in the windows, you need to do to control panel windows featuyre turn on and off (checl youtube video)
 * 
 * now go to IIS manager and then clikc on sites->defautsties and then right click on that and "Add Appl;ication" there ,
 * now there give an ALIAS for the website, select applcationpool to .net 4.5 (not sure), then for physical path you need to select the place
 * where the solution. actally select the folder as "HelloServiceIIS" and clikc Ok
 * and then right click ont he nwy crated website and switch to content view. 
 * Andnow build the solution to amke sure its all buiilding fine
 *  Now go to IIS and open the website in IIS and click on .svc and click on Briowse. it will open the WSDL Document.
 *  If thisw does not opne the wsdl document and you get some permission error then you need to folow bnelow step "I fixed mine by right clicking the entire sollution folder=>properties=>security and adding user group called IIS_IUSRS with all entitlements."
 *  Now our hosting is done, now lets open the client "WIndowsClient" and then delete the old service reference and the folder. And
 *  now righjt lick on the services and add the service by pasting the URL we got from WSDL document. aND THEN CLICK OK. AND THATS IT.
 */
