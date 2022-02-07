
class Bridge {
    constructor()
    {

    }

    static bridgeValue = "Main Page";
    static getBridgeValue() {
        return bridgeValue;
    }

    static pushBridgeValue(prop)
    {
        bridgeValue = prop
    }

}
   
  export default Bridge;