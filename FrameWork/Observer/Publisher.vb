Public Interface Publisher

    Sub add(observer As Observer)
    Sub delete(observer As Observer)
    Sub notifyObserver()

End Interface
