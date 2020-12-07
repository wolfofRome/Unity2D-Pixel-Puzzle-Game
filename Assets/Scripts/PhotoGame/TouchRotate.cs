<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        //transform.Rotate(0f, 0f, 90f);
        if (!PhotoGameControl.youWin)
            transform.Rotate(0f, 0f, 90f);
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        //transform.Rotate(0f, 0f, 90f);
        if (!PhotoGameControl.youWin)
            transform.Rotate(0f, 0f, 90f);
    }
}
>>>>>>> 3f3a041b3d2598dca96c62102c8741e440599627
