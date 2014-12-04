/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

public class GiCoreView : MgCoreView {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal GiCoreView(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.GiCoreView_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GiCoreView obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static GiCoreView createView(GiView view, int type) {
    global::System.IntPtr cPtr = touchvgPINVOKE.GiCoreView_createView__SWIG_0(GiView.getCPtr(view), type);
    GiCoreView ret = (cPtr == global::System.IntPtr.Zero) ? null : new GiCoreView(cPtr, false);
    return ret;
  }

  public static GiCoreView createView(GiView view) {
    global::System.IntPtr cPtr = touchvgPINVOKE.GiCoreView_createView__SWIG_1(GiView.getCPtr(view));
    GiCoreView ret = (cPtr == global::System.IntPtr.Zero) ? null : new GiCoreView(cPtr, false);
    return ret;
  }

  public static GiCoreView createMagnifierView(GiView newview, GiCoreView mainView, GiView mainDevView) {
    global::System.IntPtr cPtr = touchvgPINVOKE.GiCoreView_createMagnifierView(GiView.getCPtr(newview), GiCoreView.getCPtr(mainView), GiView.getCPtr(mainDevView));
    GiCoreView ret = (cPtr == global::System.IntPtr.Zero) ? null : new GiCoreView(cPtr, false);
    return ret;
  }

  public void destoryView(GiView view) {
    touchvgPINVOKE.GiCoreView_destoryView(swigCPtr, GiView.getCPtr(view));
  }

  public int acquireGraphics(GiView view) {
    int ret = touchvgPINVOKE.GiCoreView_acquireGraphics(swigCPtr, GiView.getCPtr(view));
    return ret;
  }

  public void releaseGraphics(int gs) {
    touchvgPINVOKE.GiCoreView_releaseGraphics(swigCPtr, gs);
  }

  public int acquireFrontDocs(Longs docs) {
    int ret = touchvgPINVOKE.GiCoreView_acquireFrontDocs(swigCPtr, Longs.getCPtr(docs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void releaseDocs(Longs docs) {
    touchvgPINVOKE.GiCoreView_releaseDocs(Longs.getCPtr(docs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getSkipDrawIds(Ints ids) {
    int ret = touchvgPINVOKE.GiCoreView_getSkipDrawIds(swigCPtr, Ints.getCPtr(ids));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int acquireDynamicShapesArray(Longs shapes) {
    int ret = touchvgPINVOKE.GiCoreView_acquireDynamicShapesArray(swigCPtr, Longs.getCPtr(shapes));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void releaseShapesArray(Longs shapes) {
    touchvgPINVOKE.GiCoreView_releaseShapesArray(Longs.getCPtr(shapes));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public int drawAll(int doc, int gs, GiCanvas canvas) {
    int ret = touchvgPINVOKE.GiCoreView_drawAll__SWIG_0(swigCPtr, doc, gs, GiCanvas.getCPtr(canvas));
    return ret;
  }

  public int drawAll(Longs docs, int gs, GiCanvas canvas) {
    int ret = touchvgPINVOKE.GiCoreView_drawAll__SWIG_1(swigCPtr, Longs.getCPtr(docs), gs, GiCanvas.getCPtr(canvas));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int drawAll(Longs docs, int gs, GiCanvas canvas, Ints ignoreIds) {
    int ret = touchvgPINVOKE.GiCoreView_drawAll__SWIG_2(swigCPtr, Longs.getCPtr(docs), gs, GiCanvas.getCPtr(canvas), Ints.getCPtr(ignoreIds));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int drawAppend(int doc, int gs, GiCanvas canvas, int sid) {
    int ret = touchvgPINVOKE.GiCoreView_drawAppend__SWIG_0(swigCPtr, doc, gs, GiCanvas.getCPtr(canvas), sid);
    return ret;
  }

  public int dynDraw(int shapes, int gs, GiCanvas canvas) {
    int ret = touchvgPINVOKE.GiCoreView_dynDraw__SWIG_0(swigCPtr, shapes, gs, GiCanvas.getCPtr(canvas));
    return ret;
  }

  public int dynDraw(Longs shapes, int gs, GiCanvas canvas) {
    int ret = touchvgPINVOKE.GiCoreView_dynDraw__SWIG_1(swigCPtr, Longs.getCPtr(shapes), gs, GiCanvas.getCPtr(canvas));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int drawAll(GiView view, GiCanvas canvas) {
    int ret = touchvgPINVOKE.GiCoreView_drawAll__SWIG_3(swigCPtr, GiView.getCPtr(view), GiCanvas.getCPtr(canvas));
    return ret;
  }

  public int drawAppend(GiView view, GiCanvas canvas, int sid) {
    int ret = touchvgPINVOKE.GiCoreView_drawAppend__SWIG_1(swigCPtr, GiView.getCPtr(view), GiCanvas.getCPtr(canvas), sid);
    return ret;
  }

  public int dynDraw(GiView view, GiCanvas canvas) {
    int ret = touchvgPINVOKE.GiCoreView_dynDraw__SWIG_2(swigCPtr, GiView.getCPtr(view), GiCanvas.getCPtr(canvas));
    return ret;
  }

  public int setBkColor(GiView view, int argb) {
    int ret = touchvgPINVOKE.GiCoreView_setBkColor(swigCPtr, GiView.getCPtr(view), argb);
    return ret;
  }

  public static void setScreenDpi(int dpi, float factor) {
    touchvgPINVOKE.GiCoreView_setScreenDpi__SWIG_0(dpi, factor);
  }

  public static void setScreenDpi(int dpi) {
    touchvgPINVOKE.GiCoreView_setScreenDpi__SWIG_1(dpi);
  }

  public void onSize(GiView view, int w, int h) {
    touchvgPINVOKE.GiCoreView_onSize(swigCPtr, GiView.getCPtr(view), w, h);
  }

  public void setViewScaleRange(GiView view, float minScale, float maxScale) {
    touchvgPINVOKE.GiCoreView_setViewScaleRange(swigCPtr, GiView.getCPtr(view), minScale, maxScale);
  }

  public void setPenWidthRange(GiView view, float minw, float maxw) {
    touchvgPINVOKE.GiCoreView_setPenWidthRange(swigCPtr, GiView.getCPtr(view), minw, maxw);
  }

  public void setGestureVelocity(GiView view, float vx, float vy) {
    touchvgPINVOKE.GiCoreView_setGestureVelocity(swigCPtr, GiView.getCPtr(view), vx, vy);
  }

  public bool onGesture(GiView view, GiGestureType type, GiGestureState state, float x, float y, bool switchGesture) {
    bool ret = touchvgPINVOKE.GiCoreView_onGesture__SWIG_0(swigCPtr, GiView.getCPtr(view), (int)type, (int)state, x, y, switchGesture);
    return ret;
  }

  public bool onGesture(GiView view, GiGestureType type, GiGestureState state, float x, float y) {
    bool ret = touchvgPINVOKE.GiCoreView_onGesture__SWIG_1(swigCPtr, GiView.getCPtr(view), (int)type, (int)state, x, y);
    return ret;
  }

  public bool twoFingersMove(GiView view, GiGestureState state, float x1, float y1, float x2, float y2, bool switchGesture) {
    bool ret = touchvgPINVOKE.GiCoreView_twoFingersMove__SWIG_0(swigCPtr, GiView.getCPtr(view), (int)state, x1, y1, x2, y2, switchGesture);
    return ret;
  }

  public bool twoFingersMove(GiView view, GiGestureState state, float x1, float y1, float x2, float y2) {
    bool ret = touchvgPINVOKE.GiCoreView_twoFingersMove__SWIG_1(swigCPtr, GiView.getCPtr(view), (int)state, x1, y1, x2, y2);
    return ret;
  }

  public bool submitBackDoc(GiView view, bool changed) {
    bool ret = touchvgPINVOKE.GiCoreView_submitBackDoc(swigCPtr, GiView.getCPtr(view), changed);
    return ret;
  }

  public bool submitDynamicShapes(GiView view) {
    bool ret = touchvgPINVOKE.GiCoreView_submitDynamicShapes(swigCPtr, GiView.getCPtr(view));
    return ret;
  }

  public float calcPenWidth(GiView view, float lineWidth) {
    float ret = touchvgPINVOKE.GiCoreView_calcPenWidth(swigCPtr, GiView.getCPtr(view), lineWidth);
    return ret;
  }

  public GiGestureType getGestureType() {
    GiGestureType ret = (GiGestureType)touchvgPINVOKE.GiCoreView_getGestureType(swigCPtr);
    return ret;
  }

  public GiGestureState getGestureState() {
    GiGestureState ret = (GiGestureState)touchvgPINVOKE.GiCoreView_getGestureState(swigCPtr);
    return ret;
  }

  public static int getVersion() {
    int ret = touchvgPINVOKE.GiCoreView_getVersion();
    return ret;
  }

  public bool isZoomEnabled(GiView view) {
    bool ret = touchvgPINVOKE.GiCoreView_isZoomEnabled(swigCPtr, GiView.getCPtr(view));
    return ret;
  }

  public void setZoomEnabled(GiView view, bool enabled) {
    touchvgPINVOKE.GiCoreView_setZoomEnabled(swigCPtr, GiView.getCPtr(view), enabled);
  }

  public int exportSVG(int doc, int gs, string filename) {
    int ret = touchvgPINVOKE.GiCoreView_exportSVG__SWIG_0(swigCPtr, doc, gs, filename);
    return ret;
  }

  public int exportSVG(GiView view, string filename) {
    int ret = touchvgPINVOKE.GiCoreView_exportSVG__SWIG_1(swigCPtr, GiView.getCPtr(view), filename);
    return ret;
  }

  public bool startRecord(string path, int doc, bool forUndo, int curTick, MgStringCallback c) {
    bool ret = touchvgPINVOKE.GiCoreView_startRecord__SWIG_0(swigCPtr, path, doc, forUndo, curTick, MgStringCallback.getCPtr(c));
    return ret;
  }

  public bool startRecord(string path, int doc, bool forUndo, int curTick) {
    bool ret = touchvgPINVOKE.GiCoreView_startRecord__SWIG_1(swigCPtr, path, doc, forUndo, curTick);
    return ret;
  }

  public void stopRecord(bool forUndo) {
    touchvgPINVOKE.GiCoreView_stopRecord(swigCPtr, forUndo);
  }

  public bool recordShapes(bool forUndo, int tick, int changeCount, int doc, int shapes) {
    bool ret = touchvgPINVOKE.GiCoreView_recordShapes__SWIG_0(swigCPtr, forUndo, tick, changeCount, doc, shapes);
    return ret;
  }

  public bool recordShapes(bool forUndo, int tick, int changeCount, int doc, int shapes, Longs exts, MgStringCallback c) {
    bool ret = touchvgPINVOKE.GiCoreView_recordShapes__SWIG_1(swigCPtr, forUndo, tick, changeCount, doc, shapes, Longs.getCPtr(exts), MgStringCallback.getCPtr(c));
    return ret;
  }

  public bool recordShapes(bool forUndo, int tick, int changeCount, int doc, int shapes, Longs exts) {
    bool ret = touchvgPINVOKE.GiCoreView_recordShapes__SWIG_2(swigCPtr, forUndo, tick, changeCount, doc, shapes, Longs.getCPtr(exts));
    return ret;
  }

  public bool undo(GiView view) {
    bool ret = touchvgPINVOKE.GiCoreView_undo(swigCPtr, GiView.getCPtr(view));
    return ret;
  }

  public bool redo(GiView view) {
    bool ret = touchvgPINVOKE.GiCoreView_redo(swigCPtr, GiView.getCPtr(view));
    return ret;
  }

  public bool onPause(int curTick) {
    bool ret = touchvgPINVOKE.GiCoreView_onPause(swigCPtr, curTick);
    return ret;
  }

  public bool onResume(int curTick) {
    bool ret = touchvgPINVOKE.GiCoreView_onResume(swigCPtr, curTick);
    return ret;
  }

  public bool restoreRecord(int type, string path, int doc, int changeCount, int index, int count, int tick, int curTick) {
    bool ret = touchvgPINVOKE.GiCoreView_restoreRecord(swigCPtr, type, path, doc, changeCount, index, count, tick, curTick);
    return ret;
  }

  public void traverseOptions(MgOptionCallback c) {
    touchvgPINVOKE.GiCoreView_traverseOptions(swigCPtr, MgOptionCallback.getCPtr(c));
  }

  public void setOptionBool(string name, bool value) {
    touchvgPINVOKE.GiCoreView_setOptionBool(swigCPtr, name, value);
  }

  public void setOptionInt(string name, int value) {
    touchvgPINVOKE.GiCoreView_setOptionInt(swigCPtr, name, value);
  }

  public void setOptionFloat(string name, float value) {
    touchvgPINVOKE.GiCoreView_setOptionFloat(swigCPtr, name, value);
  }

  public void setOptionString(string name, string value) {
    touchvgPINVOKE.GiCoreView_setOptionString(swigCPtr, name, value);
  }

  public static readonly int kNoCmdType = touchvgPINVOKE.GiCoreView_kNoCmdType_get();
  public static readonly int kTestType = touchvgPINVOKE.GiCoreView_kTestType_get();
  public static readonly int kNormalType = touchvgPINVOKE.GiCoreView_kNormalType_get();

}

}