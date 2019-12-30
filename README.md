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

