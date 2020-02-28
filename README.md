# Programming_2017.2
Programming_2017.2

Roll-a-ball PickUp
unity3d 通过添加rigidBody来指明物体是动态的，以避免cache开销。
如果不添加rigidBody，则unity会认为它是静态的，会对物理计算进行cache，但如果此物体实际上transform一直在发生变化，则unity会不断更新cache，结果反而不如指明其为动态物体效率高。