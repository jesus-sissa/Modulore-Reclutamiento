Module MoludoHuellas

    ' #################################################################################################
    '
    '   NBioAPI.bas   : Define constants for NBioAPI
    '
    '   Copyright     : NITGEN Co., Ltd.
    '
    ' #################################################################################################

    ' -------------------------------------------------------------------------------------------------
    '   Error code
    ' -------------------------------------------------------------------------------------------------

    Public Const NBioAPIERROR_NONE = 0


    ' -------------------------------------------------------------------------------------------------
    '   General
    ' -------------------------------------------------------------------------------------------------

    ' True / False
    Public Const NBioAPI_TRUE = 1
    Public Const NBioAPI_FALSE = 0

    ' -------------------------------------------------------------------------------------------------
    '   Device
    ' -------------------------------------------------------------------------------------------------

    ' Constant for DeviceID
    Public Const NBioAPI_DEVICE_ID_NONE = 0
    Public Const NBioAPI_DEVICE_ID_FDP02_0 = 1
    Public Const NBioAPI_DEVICE_ID_FDU01_0 = 2
    Public Const NBioAPI_DEVICE_ID_OSU02_0 = 3
    Public Const NBioAPI_DEVICE_ID_FDU11_0 = 4
    Public Const NBioAPI_DEVICE_ID_FSC01_0 = 5
    Public Const NBioAPI_DEVICE_ID_FDU03_0 = 6
    Public Const NBioAPI_DEVICE_ID_AUTO_DETECT = 255

    ' Constant for Device Name
    Public Const NBioAPI_DEVICE_NAME_FDP02 = 1
    Public Const NBioAPI_DEVICE_NAME_FDU01 = 2
    Public Const NBioAPI_DEVICE_NAME_OSU02 = 3
    Public Const NBioAPI_DEVICE_NAME_FDU11 = 4
    Public Const NBioAPI_DEVICE_NAME_FSC01 = 5
    Public Const NBioAPI_DEVICE_NAME_FDU03 = 6

    ' -------------------------------------------------------------------------------------------------
    '   BSP
    ' -------------------------------------------------------------------------------------------------

    ' Constant for Security Level
    Public Const NBioAPI_FIR_SECURITY_LEVEL_LOWEST = 1
    Public Const NBioAPI_FIR_SECURITY_LEVEL_LOWER = 2
    Public Const NBioAPI_FIR_SECURITY_LEVEL_LOW = 3
    Public Const NBioAPI_FIR_SECURITY_LEVEL_BELOW_NORMAL = 4
    Public Const NBioAPI_FIR_SECURITY_LEVEL_NORMAL = 5
    Public Const NBioAPI_FIR_SECURITY_LEVEL_ABOVE_NORMAL = 6
    Public Const NBioAPI_FIR_SECURITY_LEVEL_HIGH = 7
    Public Const NBioAPI_FIR_SECURITY_LEVEL_HIGHER = 8
    Public Const NBioAPI_FIR_SECURITY_LEVEL_HIGHEST = 9

    ' Purpose for FIR
    Public Const NBioAPI_FIR_PURPOSE_VERIFY = 1
    Public Const NBioAPI_FIR_PURPOSE_IDENTIFY = 2
    Public Const NBioAPI_FIR_PURPOSE_ENROLL = 3
    Public Const NBioAPI_FIR_PURPOSE_ENROLL_FOR_VERIFICATION_ONLY = 4
    Public Const NBioAPI_FIR_PURPOSE_ENROLL_FOR_IDENTIFICATION_ONLY = 5
    Public Const NBioAPI_FIR_PURPOSE_AUDIT = 6
    Public Const NBioAPI_FIR_PURPOSE_UPDATE = 10

    ' Finger ID
    Public Const NBioAPI_FINGER_ID_UNKNOWN = 0
    Public Const NBioAPI_FINGER_ID_RIGHT_THUMB = 1
    Public Const NBioAPI_FINGER_ID_RIGHT_INDEX = 2
    Public Const NBioAPI_FINGER_ID_RIGHT_MIDDLE = 3
    Public Const NBioAPI_FINGER_ID_RIGHT_RING = 4
    Public Const NBioAPI_FINGER_ID_RIGHT_LITTLE = 5
    Public Const NBioAPI_FINGER_ID_LEFT_THUMB = 6
    Public Const NBioAPI_FINGER_ID_LEFT_INDEX = 7
    Public Const NBioAPI_FINGER_ID_LEFT_MIDDLE = 8
    Public Const NBioAPI_FINGER_ID_LEFT_RING = 9
    Public Const NBioAPI_FINGER_ID_LEFT_LITTLE = 10

    ' Window Style
    Public Const NBioAPI_WINDOW_STYLE_POPUP = 0
    Public Const NBioAPI_WINDOW_STYLE_INVISIBLE = 1     'only for NBioAPI_Capture()
    Public Const NBioAPI_WINDOW_STYLE_CONTINUOUS = 2

    Public Const NBioAPI_WINDOW_STYLE_NO_FPIMG = 65536
    Public Const NBioAPI_WINDOW_STYLE_TOPMOST = 131072  ' currently not used (after v2.3)
    Public Const NBioAPI_WINDOW_STYLE_NO_WELCOME = 262144
    Public Const NBioAPI_WINDOW_STYLE_NO_TOPMOST = 524288

    ' -------------------------------------------------------------------------------------------------
    '   Export Data
    ' -------------------------------------------------------------------------------------------------
    Public Const MINCONV_TYPE_FDP = 0
    Public Const MINCONV_TYPE_FDU = 1
    Public Const MINCONV_TYPE_FDA = 2
    Public Const MINCONV_TYPE_OLD_FDA = 3
    Public Const MINCONV_TYPE_FDAC = 4
    Public Const MINCONV_TYPE_FIM10_HV = 5
    Public Const MINCONV_TYPE_FIM10_LV = 6
    Public Const MINCONV_TYPE_FIM01_HV = 7
    Public Const MINCONV_TYPE_FIM01_HD = 8
    Public Const MINCONV_TYPE_FELICA = 9
    ' -------------------------------------------------------------------------------------------------
    '   Export Image
    ' -------------------------------------------------------------------------------------------------

    ' Constant for FP Image
    Public Const NBioAPI_IMG_TYPE_RAW = 1
    Public Const NBioAPI_IMG_TYPE_BMP = 2
    Public Const NBioAPI_IMG_TYPE_JPG = 3



End Module
