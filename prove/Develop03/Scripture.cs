class Scripture 
{
    private string scriptText;

    private Reference scriptRef;

    public Scripture (Reference _scriptRef, string _ScriptText)
    {
        scriptRef = _scriptRef;
        scriptText = _ScriptText;
    }

    public string toString()
    {
        return string.Format("{0}", scriptText);
    }


}