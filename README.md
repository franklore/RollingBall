﻿Unity3d example

##涉及到的内容##

1. 界面的基本操作方法
2. GameObject：新建，调整Transform（位置、旋转和尺寸），添加组件（Component），父物体和子物体（Parent, Child）
3. Material，Albedo，Color，Shader->Unlit->Transparent使用透明贴图
4. 物理：刚体（Rigidbody），AddForce，碰撞（Collision, Collider），isTrigger，OnCollisionEnter以及类似的函数，Physic Material
5. Input
6. 预制件（prefab）：将一个物体从Hierarchy拖入Project中保存为预制件，用Instantiate来实例化

######

1. 在inspector中出现的变量都可以在Scripting API中查到，有的变量可以直接赋值修改。
2. 在脚本中将变量声明为public，可以在inspector中对应的代码的Component下看到，将scene中的一个物体或project中的一个预制件拖入框内可以将该变量指定为此物体
3. 不会的地方要勤查文档
4. 待添加
