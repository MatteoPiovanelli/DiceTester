namespace DiceTester


module DnD5e = 

    let acRange low high =
        [ for ac in low .. high do
            yield ac ]

