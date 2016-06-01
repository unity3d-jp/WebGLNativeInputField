var WebNativeDialog = {
   NativeDialogPrompt:function (title , defaultValue){
     defaultValue = Pointer_stringify(defaultValue);
     title = Pointer_stringify(title);
     var result = window.prompt( title , defaultValue );
     if( !result ){
       result = defaultValue;
     }
     var buffer = _malloc(lengthBytesUTF8(result) + 1);
     writeStringToMemory(result, buffer);
     return buffer;
   }
};
mergeInto( LibraryManager.library , WebNativeDialog );

