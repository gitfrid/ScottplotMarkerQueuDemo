# ScottplotMarkerQueuDemo
<br>
<br> Scottplot ConcurrentQueu C# Forms Demo Example
<br>
<br><strong>C# example with ConcurrentQueue using ScpottPlot WinForms 4.1.70</strong>
<br>
<img src="https://github.com/gitfrid/ScottplotMarkerQueuDemo/blob/eaedc80f975ba92b9aa319bbf357a4443fa68cc3/Documentation/Scottplot_ConcurrentQueue_Workflow.png" width="50%" height="50%" />
<br>
<br>
<br><strong>Scottplot Marker ConcurrentQueu 23000 Points</strong>
<img src="https://github.com/gitfrid/ScottplotMarkerQueuDemo/blob/eac953b28c794678d2208b98ef7aaffd1833573d/Documentation/Marker%20Plot%2023000%20Points.png" width="50%" height="50%" />
<br>Live zooming in the diagram is still performant with the number of points 
<br>
<br>The iteration speed slows down by a factor of 10 to 100 from 20000 points.
<br>I don't know exactly what the reason is - probably the cost of rendering or my code.
<br>For most applications it is sufficient, otherwise for example only every tenth point could be drawn.
<br>
<br>There is no serious slowdown in the iterations using Scottplot signal below, even at 50000 points.
<br>Live zooming is also very powerful.
<br>As far as I know, it is suitable for ascending X values, not for an X/Y diagram where the X values are uneven.
<br>
<br>Workaround: The iteration performance increases if you zoom
<br>into the white area so that the points are outside the boundaries,
<br>or minimizing the window.
<br>
<br><strong>Scottplot Marker ConcurrentQueu 23000 Points zoom in</strong>
<img src="https://github.com/gitfrid/ScottplotMarkerQueuDemo/blob/0fbda60a4143ba039886b1ff19e26bc465abad89/Documentation/Marker%20Plot%2023000%20Points%20zoom.png" width="50%" height="50%" />
<br>
<br>
<br>
<br><strong>Scottplot Line ConcurrentQueu 17000 Lines</strong>
<img src="https://github.com/gitfrid/ScottplotMarkerQueuDemo/blob/eac953b28c794678d2208b98ef7aaffd1833573d/Documentation/Lines%20Plot%2017000%20Points.png" width="50%" height="50%" />
<br>
<br>
<br><strong>Scottplot Signal ConcurrentQueu 50000 Signal Points</strong>
<img src="https://github.com/gitfrid/ScottplotMarkerQueuDemo/blob/eac953b28c794678d2208b98ef7aaffd1833573d/Documentation/Signal%20Plot%2050000%20Points.png" width="50%" height="50%" />
<br>
<br>


