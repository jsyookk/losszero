Imports System.Threading
Public Class FrameWork

    Dim bg As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker()

    Private splashProgress As ProgressForm

    Private loginComplete As Boolean = False
    Private msgCon As Label
    Private resultpublisher As Publisher
    Private resultRefersh As Boolean = False


    Enum STATUS

        NONE = 100
        FILELOAD_COMPLETE = 102
        FILELOAD_BAR = 103
        FILELOAD_DBF = 104
        LOGIN_OFFLINE = 105
        LOGIN_ONLINE = 106
        EXPORT_DBF = 107
        EXPORT_DBF_COMPLETE = 108
        PROCESS_OPTIMAL = 109
        PROCESS_COMPLETE = 110

    End Enum


    Private st As STATUS = STATUS.NONE
    Private Shared _thisInstance As FrameWork = Nothing

    Public Sub registerResultPublish(pub As Publisher)

        resultpublisher = pub

    End Sub

    Public Function getStatus() As STATUS

        Return st

    End Function

    Public Function isLoginComplete() As Boolean

        Return loginComplete

    End Function

    Public Sub setStatus(st_ As STATUS)

        st = st_

        Select Case st

            Case STATUS.FILELOAD_DBF
                DataMgrFacade.DataAllClear()
                Message("dbf 파일을 로드 중입니다")

            Case STATUS.FILELOAD_COMPLETE
                Message("파일 읽기가 완료되었습니다")

            Case STATUS.LOGIN_ONLINE
                load_Init()
                loginComplete = True
                Main.login_complete()
                Message("로그인 되었습니다")
            Case STATUS.LOGIN_OFFLINE
                Message("비로그인 상태입니다.로그인을 해주세요.")
            Case STATUS.EXPORT_DBF
                Message("파일 저장중입니다.")
            Case STATUS.EXPORT_DBF_COMPLETE
                MessageBox.Show("저장이 완료 되었습니다.")
            Case STATUS.PROCESS_OPTIMAL
                Message("최적화 실행 중입니다.")
                'Main.showProgress(True)

                Dim alg As New AlogFacade()
                Dim thread As New Thread(AddressOf alg.alogExec)
                thread.Start()
                thread.Join()


                setStatus(STATUS.PROCESS_COMPLETE)

            Case STATUS.PROCESS_COMPLETE
                'Main.showProgress(False)
                resultpublisher.notifyObserver()
                Message("최적화가 완료 되었습니다.")



        End Select

    End Sub
    Private Sub load_Init()

        Dim zxmlshape As ZXml = New ZXmlShape()
        zxmlshape.open(My.Application.Info.DirectoryPath & "\shape\shapeList.xml")

        MakeDirctory.MakeDir(My.Application.Info.DirectoryPath & "\xml")

        Dim zxmlstock As ZXml = New ZXmlStock()
        zxmlstock.isFileCheck(My.Application.Info.DirectoryPath & "\xml\stock.xml")
        zxmlstock.open(My.Application.Info.DirectoryPath & "\xml\stock.xml")

        Dim zxmlcoil As ZXml = New ZXmlCoilShpae()
        zxmlcoil.isFileCheck(My.Application.Info.DirectoryPath & "\xml\coilshapeList.xml")
        zxmlcoil.open(My.Application.Info.DirectoryPath & "\xml\coilshapeList.xml")

        '설정값 로드
        Dim loadXml As ZSerialization = New ZXmlSerialization()
        loadXml.isFileCheck(My.Application.Info.DirectoryPath & "\xml\setting.xml")
        loadXml.load(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        '기준값
        BasePrice.GetInstance().inputBasePrice(SettingInfo.GetInstance().basePrice)
        Dim steelm As SteelMeter = SteelMeter.GetInstance()

        RandomChar.InputText()


    End Sub

    Public Sub registerMessageControl(msgcontrol As Label)
        msgCon = msgcontrol
    End Sub
    Public Sub Message(msg_ As String)

        msgCon.Text = msg_

    End Sub

    Public Shared ReadOnly Property GetInstance As FrameWork

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New FrameWork
            End If

            Return _thisInstance
        End Get

    End Property


End Class
