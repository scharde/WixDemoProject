using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Microsoft.Deployment.WindowsInstaller;

namespace WixNewProjCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult SetLastDialogName(Session session)
        {
            //session.Log("Start SetDialogName");

            //var currentDialog = session["CURRENT_DIALOG"];

            //Trace.WriteLine("currentDialog : " +  currentDialog);

            //string dialogSequenceList = session["DIALOG_SEQUENCE"];
            //Trace.WriteLine("dialogSequenceList : " + dialogSequenceList);
            //dialogSequenceList = string.Concat(dialogSequenceList, ",", currentDialog);
            //session["DIALOG_SEQUENCE"] = dialogSequenceList;
            //Trace.WriteLine("New List : " + dialogSequenceList);

            //session["LAST_DIALOG"] = currentDialog;

            //Trace.WriteLine("LAST_DIALOG: " + session["LAST_DIALOG"]);

            //session.Log("End SetDialogName");

            return ActionResult.Success;
        }


        [CustomAction]
        public static ActionResult SetPreviousDialogOnBackBtn(Session session)
        {
            //session.Log("Start SetDialogName");

            //var currentDialog = session["CURRENT_DIALOG"];

            //Trace.WriteLine("currentDialog : " + currentDialog);

            //string dialogSequenceList = session["DIALOG_SEQUENCE"];
            //dialogSequenceList = dialogSequenceList.Remove(session["LAST_DIALOG"]);


            //Trace.WriteLine("dialogSequenceList : " + dialogSequenceList);
            //dialogSequenceList = string.Concat(dialogSequenceList, ",", currentDialog);
            //session["DIALOG_SEQUENCE"] = dialogSequenceList;
            //Trace.WriteLine("New List : " + dialogSequenceList);

            //session["LAST_DIALOG"] = currentDialog;

            //Trace.WriteLine("LAST_DIALOG: " + session["LAST_DIALOG"]);

            //session.Log("End SetDialogName");

            return ActionResult.Success;
        }
    }
}
