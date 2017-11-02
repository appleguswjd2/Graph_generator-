function [x,y]= graphGenerator(mode,xStart,xEnd,yStart,yEnd)


if yStart>yEnd
    fs=2*yStart;
else
    fs=2*yEnd;
end

 ts=1/fs;
 x=xStart:ts:xEnd;
 a=yStart;
 b=yEnd;
if mode==0.1
    %mode 1 : linear graph
    y =(b-a).*x+a;
    i=1;
elseif mode==0.2;
  %mode 2 : log graph
    y=log((b-a).*x);
    i=2;
elseif mode==0.3;
    %mode 3: non-linear graph
    k=100*(a-b);
    y =-(k*(x.^2))+a;
    i=3;
end


% plot(x,y);
% title(sprintf('Graph of Mode %d', i))
% xlabel('X value') % x-axis label
% ylabel('Y value') % y-axis label

