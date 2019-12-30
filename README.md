# Build an Augmented Reality Business Card Using Unity
## Prerequisites:
<ul>
  <li>Unity <b>v2019.1.4</b> (Make Sure That You Have The Right Version)</li>
  <li>Vuforia Support for Unity</li>
  <li>iOS/Android Build Support (Optional, iOS Support requires macOS and the latest version of XCode</li>
  <li>Unity Package and Targets Folder (Link Provided in the description)</li>
</ul>
<a href="https://drive.google.com/file/d/1QMMQdD05Ew1Ay7oGONOFif4wtGZSUxsP/view?usp=sharing">Download Unity Package</a></br>
<a href="Targets" download> Download Targets Folder</a>

## Setup Unity
<ul>
<li>1.	First, after installing Unity Hub and opening we will click on “New”, we will select “3D” as a template, name the project and select its location. Then we click on “create”.</li>
<li>2.	We go to where we have saved the file of the given design package “Assembly.unitypackage” and open the file.</li>
<li>3.	We click on Import.</li>
<li>4.	On the left under “Sample Scene”, we delete both “Main Camera” and ‘Directional Light” and Save.</li>
<li>5.	We go to the “GameObject” tab and select “Vuforia Engine” and then “AR Camera”.</li>
<li>6.	We left Click on “AR Camera” and then elect “Vuforia Engine” and then select “Image”. We would notice that we have “Image Target: added underneath AR Camera. Then we save.</li>
<li>7.	Now we have to add a database so we go to https://developer.vuforia.com/vui/auth/register to register with your info then we say “create account” </li>
<li>8.	You will have to verify your email address by clicking on the link sent to your email. </li>
<li>9.	Now we login to https://developer.vuforia.com/vui/auth/login with the previously set email and password.</li>
<li>10.	After getting logged in, we click “Get Development Key” and then proceed to “License Manager” where we will enter a License name we like and then check the box below and click “confirm”.</li>
<li>11.	Now that we have a license created, we click on it and copy the given license key.</li>
<li>12.	Then we go back to Unity and go to “Edit” tab, then “Project Settings”. Then we go down to “XR Settings and check the “Vuforia Augmented Reality Support” in all three tabs.</li>
<li>13.	We then close that window and select “AR Camera” and on the right, we select “Open Vuforia Engine Configuration” and paste the hash we copied before under “App License Key”. Then we click “Add License”.</li>
<li>14.	Now, we go back to Vuforia and select the “Target Manager” tab. We click on “Add Database”. We give it a name and check Type “ Device” then click “create”.</li>
<li>15.	Then we download the “Targets” file from github on this link https://github.com/The-Assembly/Augmented-Reality-Business-Card/tree/master/Targets </li>
<li>16.	Now that we have created a database, we have to add targets. We click on it and then select “Add Target”. </li>
<li>17.	We then Select Type “Single Image”. We browse to “Assembly.jpg”. Then we say width is “1” and select “Add”.</li>
<li>18.	Then we add our 2nd Target following the same steps but choosing “Untitled-1.jpg” instead.</li>
<li>19.	Then we add our 3rd Target by Selecting Type “3D Object” and browsing to “7gc.od” and then clicking “Add”.</li>
<li>20.	Now that we have our database with our targets, we select “Download Database All” and then check “Unity Editor”. Then select “Download”. </li>
<li>21.	We open the file we just downloaded and select “Import”.</li>
</ul>

## Sirius Black Poster 

The Harry Potter Franchise has always been a favorite of many and so is their animated Daily Wizards Newspaper “Daily Prophet”. For this reason, we will be showing how to create such a poster using Unity where you could bring newspaper images to life with Augmented Reality Technology. <br><ul>

<li>1.	Go to “Image Target” and then “Image Target Behaviour”. Then Select the database we named before and then “untitled-1.jpg” as Image Target.</li>
<li>2.	Now we select “ Image Target” and then “3D Object” then “Quad”.</li>
<li>3.	Now we go to “Transform” tab on the right and then “Rotation” and write “90” in the x-axis.</li>
<li>4.	Now we scale he quad down into sirus black image size.</li>
<li>5.	Now we go to “Add Component” in “Quad” and select “Video Player”</li>
<li>6.	Then we go to “Assets” and then “Videos” and drag the Sirus black video to the “Video Clip” tab.</li>
<li>7.	Then we go to Assets  Vuforia  Scripts  DefaultTrackableEventHandler.cs and open it.</li>
<li>8.	We alter the code by adding at the top “ using UnityEngine.Video; ”</li>
<li>9.	Then we go to the “On Tracking Lost ()”  method and add a line at the end with “mTrackableBehaviour.gameObject.GetComponentInChildren<VideoPlayer>().Stop();”</li>
<li>10.	Then we go to the “On Tracking Found ()”  method and add a line at the end with 
“mTrackableBehaviour.gameObject.GetComponentInChildren<VideoPlayer>().Play();”</li>
  </ul>
  
##  AR Business Card 

The humble business card has always been a simple but effective tool for professional networking, yet the advent of technology threatens to render it obsolete in a paperless, online world. However, technology itself may provide a reprieve with the possibility of supercharging your card with augmented reality experiences.
The card no longer needs to be restricted to simple textual information, instead becoming a real world anchor for all sorts of media and interactivity to breathe life into your profile - accessible on the fly and on demand. In this workshop, we’ll show you how to use Unity & Vuforia to turn a simple printed card into a mixed reality portal for a wide array of interactive features including video and 3D animation - all over layed on top of your card as viewed through the app. <br><ul>

<li>1.	Under “AR Camera”, we create an “Image Target”.</li>
<li>2.	We go to image Target and select the previously created database and ‘Assembly” as Target</li>
<li>3.	Then we add 3D Object  Cylinder and scale it as x=1 and z=0.7.</li>
<li>4.	Now we go to Business Card Folder and select a photo and drop it in the cylinder</li>
<li>5.	Then we copy paste 5 cylinders and paste their pictures inside.</li>
<li>6.	Now we add 3D Object  Quad and then rotate it 90 degrees in the x-axis direction.</li>
<li>7.	We then select the user avatar and drop it in the quad</li>
<li>8.	Then we add 3D Object Text (Text Mesh Pro)</li>
<li>9.	We go to Window  Text Mesh Pro and Import both “TMP Essential Resources” & “TMP Examples and Extras”.</li>
<li>10.	We select Font size as “1.5” and Fill in User Details such as “Name” and “Address”</li>
<li>11.	Now we go to the “Assets” folder and create a folder named “Scripts”. Then inside the folder, we create a “C# Script” and rename it according to what we want. For Example : “Instagram”.</li>
<li>12.	Then we open the script and delete methods “Start()” and “Update()” </li>
<li>13.	Now, we add method “OnMouseDown()” and add this line “Application.OpenURL();” where we paste the link of the wanted social media platform between the ().</li>
<li>14.	Then we pick the script and drop it in “Add Component” for that object.</li>
<li>15.	We repeat the same steps above for the rest of the social media links.</li>
</ul>


## Object Recognition using Vuforia


Similar to 2D image recognition, Vuforia supports 3D object recognition. The required target (object) could be scanned using Object Scanner app provided by Vuforia for Android. For this workshop, since the Object Scanner app is exclusive for Android, a scanned object is provided. We need to add this object to the Targets database online similar to how we added the image targets. <br><ul>

<li>1.	We select AR Camera  Vuforia Engine  3D Scan</li>
<li>2.	We make sure that the Target is 66.od</li>
<li>3.	Then we include the controls from the business card under ObjectTarget.</li>
<li>4.	Set the position of the objects to 0 so that it would be placed close to the object target and then adjust the placement according to your requirement.</li></ul>

## Exporting into an App


To export the whole scene into an application, we follow these steps:<br><ul>
<li>1.	We go to file  Build Settings </li>
<li>2.	Then we select “Add Open Scenes”</li>
<li>3.	Then we select the preferred platforms. In this case it’s iOS or Android.</li>
<li>4.	Now we select “Switch Platform” and then select “Build and Run”.</li></ul>
  <b>Note:</b> for iOS exporting, you need to have the latest version of XCode but for Android Exporting, it won’t be an issue.


