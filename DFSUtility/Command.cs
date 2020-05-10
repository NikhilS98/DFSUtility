using System;
using System.Collections.Generic;
using System.Text;

namespace DFSUtility
{
    public enum Command
    {
        none,
        clientConnect,
        requestFileTree,
        serverConnect,
        openFile,
        updateFile,
        ls,
        cd,
        mkdir,
        rmdir,
        rm,
        mvdir,
        mv,
        cpdir,
        cp,
        stats,
        wait,
        updateFileTree,
        updateConfig,
        forwarded
    }
}
