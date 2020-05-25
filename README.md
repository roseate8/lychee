# lychee
 foveated rendering bs

--

foveated rendering shader written in htc sdk (check other codes but it uses rtx2080) https://github.com/ViveSoftware/ViveFoveatedRendering/blob/master/UnityPackage/ViveFoveatedRendering/Shader/VisualizeViveFoveatedRendering.shader

 1. import a triangular mesh into unity
 2. display number of triangles
 3. fffff


demo scene:
1. meshInfo
    Just an empty object to count the triangles in the mesh. Also calculates other mesh information
2. UI

    2.1 
    Slider - referenced in the code GPUSubDivTest.cs and takes in value for subdivision level

    2.2 
    Text - just prints out the same slider value. ble

    2.3 
    Button - Click to apply that subdivision level. same script bs.

3. importObject
    Has a script to import obj files. Open the script and update the file path for it to work. 
    still need to make an input field and take in info from that. Lets see. its easy. maybe try
    it should have the Flatwireframe shader in the reference attached. 
        you know, under the script, in that box shit.
    Oh and the flatwireframe material as well.
    