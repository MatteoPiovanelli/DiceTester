namespace DiceTester


module dnd5e = 

    let acRange low high =
        [ for ac in low .. high do
            yield ac ]