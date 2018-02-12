Repo to demonstrate issues with Forms **ImageCell**, a **PCL** project, and **Android**

## Repo Folders:
- NS - Net Standard Project
- PCL - PCL Project
- Shared - Share Project

## Desc
Using the latest Forms and a PCL project... a XAML ImageCell with a hardcoded source ```may``` timeout and return an error.

```xml
<ImageCell
    ImageSource="https://www.xamstatic.com/dist/images/pages/platform/visual-studio-icon-uHIZMvQl.png"
    Text="{Binding Name}"
    Detail="{Binding Job}">
</ImageCell>
```

## Error:

#### Full Log: [output.txt](output.txt)

#### Error Snippet:
```Image Loading: Error getting stream for https://www.xamstatic.com/dist/images/pages/platform/visual-studio-icon-uHIZMvQl.png: System.Threading.Tasks.TaskCanceledException: A task was canceled.```

*...*

```[0:] ImageLoaderSourceHandler: Could not retrieve image or image data was invalid: Uri: https://www.xamstatic.com/dist/images/pages/platform/visual-studio-icon-uHIZMvQl.png```

---


```
[0:] Image Loading: Error getting stream for https://www.xamstatic.com/dist/images/pages/platform/visual-studio-icon-uHIZMvQl.png: System.Threading.Tasks.TaskCanceledException: A task was canceled.
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x00026] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter`1[TResult].GetResult () [0x00000] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Net.Http.HttpClientHandler+<SendAsync>d__63.MoveNext () [0x00528] in <35658e59c86d40bdbb2ef0bb34b4f0c7>:0 
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0001a] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Net.Http.HttpClient+<SendAsyncWorker>d__49.MoveNext () [0x000ca] in <35658e59c86d40bdbb2ef0bb34b4f0c7>:0 
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0001a] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter`1[TResult].GetResult () [0x00000] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at Xamarin.Forms.Forms+AndroidPlatformServices+<GetStreamAsync>d__16.MoveNext () [0x0003e] in D:\agent\_work\2\s\Xamarin.Forms.Platform.Android\Forms.cs:448 
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0001a] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <657aa8fea4454dc898a9e5f379c58734>:0 
  at Xamarin.Forms.UriImageSource+<GetStreamAsyncUnchecked>d__23.MoveNext () [0x00224] in D:\agent\_work\2\s\Xamarin.Forms.Core\UriImageSource.cs:174 
[0:] ImageLoaderSourceHandler: Could not retrieve image or image data was invalid: Uri: https://www.xamstatic.com/dist/images/pages/platform/visual-studio-icon-uHIZMvQl.png
```
